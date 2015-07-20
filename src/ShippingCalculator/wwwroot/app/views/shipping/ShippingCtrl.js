var app = angular.module('ShippingCalculator');

app.controller('ShippingCtrl', function ($scope, ShippingService) {
    $scope.calculate = function (zip, weight) {
        ShippingService.calculateShipping(zip, weight).then(function (total) {
            $scope.total = total;
        });
    }
});