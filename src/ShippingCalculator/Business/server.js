var express = require('express');
var bodyParser = require('body-parser');
var app = express();

app.use(bodyParser.json());

app.use(express.static(__dirname));

var zones = {
    '55555': 4,
    '55556': 3,
    '55557': 9
}

var zonePrices = {
    '4': {
        weightCost: [{
            weight: 1,
            cost: 1.25
        }, {
            weight: 1.5,
            cost: 2
        }, {
            weight: 2,
            cost: 3.25
        }]
    }
}
    
function getZone(zip, res) {
    var zone = zones[zip];
    if (!zone) {
        return res.json({ error: 'We are sorry but that appears to be an invalid shipping zone' });
    }
    return zone;
}

function calculateTotal(zone, weight, res) {
    var zonePrice = zonePrices[zone];
    if (!zonePrice) {
        return res.json({ error: 'Sorry we cannot ship to that location at this time' });
    }
    var cost = null;
    zonePrice.weightCost.some(function (val) {
        if (val.weight === weight) {
            cost = val.cost;
            return true;
        }
        return false;
    });
    if (cost === null) {
        return res.json({ error: 'Sorry it looks like we can\'t send a package of ' + weight + ' to this zone' });
    }
    return cost;
}

app.post('/calculate', function (req, res) {
    var delivery = req.body.delivery
    var zone = getZone(delivery.zip, res);
    var total = calculateTotal(zone, delivery.weight, res);
    if (total) {
        return res.json(total);
    }
});


app.listen(8080, function () {
    console.log('Listening on port: 8080');
});
