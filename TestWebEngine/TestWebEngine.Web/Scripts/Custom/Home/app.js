"use strict";

var homeApp = angular.module("homeApp", [
    "ngRoute",
    "homeControllers"
]);

homeApp.config(['$routeProvider',
    function ($routeProvider) {
        $routeProvider
            .when('/', {
                templateUrl: '/Home/Index/',
                controller: 'HomeCtrl'
            })
            .when('/Home/Next', {
                templateUrl: '/Home/Next/',
                controller: 'StartCtrl'
            })
            .otherwise({
                redirectTo: '/'
            });
    }
])