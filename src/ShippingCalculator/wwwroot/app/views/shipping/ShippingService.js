var app = angular.module('ShippingCalculator');

app.factory('ShippingService', function ($http) {
    return {
        calculateShipping: function (zip, weight) {
            var url = '/api/shippingcalculator/' + zip + '/' + weight;
            return $http({
                method: 'GET',
                url: url
            }).then(function (res) {
                console.log(res);
                return res.data;
            });
        }
    }
});