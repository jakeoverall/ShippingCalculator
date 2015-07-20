var app = angular.module('ShippingCalculator', [
    'ui.router'
]);

app.config(function ($httpProvider, $stateProvider, $urlRouterProvider) {
    $httpProvider.defaults.useXDomain = true;
    delete $httpProvider.defaults.headers.common['X-Requested-With'];
    $urlRouterProvider.otherwise('/');
    $stateProvider
        .state('main', {
            url: '/',
            templateUrl: 'app/views/main.html',
        })
        .state('contact', {
            url: '/contact',
            templateUrl: 'app/views/contact/contact.html'
        })
        .state('shipping', {
            url: '/shipping',
            templateUrl: 'app/views/shipping/form.html',
            controller: 'ShippingCtrl'
        });
});