"use strict";

var appName = "Home";

var homeApp = angular.module("homeApp", [
    "ngRoute",
    "homeControllers"
]);

homeApp.config([
    '$routeProvider',
    function($routeProvider) {
        $routeProvider
            .when('/', {
                title: 'Index Page',
                templateUrl: '/Home/Index/',
                controller: 'HomeCtrl'
            })
            .when('/Home/Next', {
                title: 'Next Page',
                templateUrl: '/Home/Next/',
                controller: 'StartCtrl'
            })
            .otherwise({
                redirectTo: '/'
            });
    }
]);

homeApp.run(['$rootScope', function($rootScope) {
        $rootScope.page = {
            setTitle: function(title) {
                this.title = appName + ' | ' + title;
            },
            links: [
                { name: 'Index Page', path: '/Home/Index/' },
                { name: 'Next Page', path: '/Home/Next/' }
            ]
        };

        $rootScope.$on('$routeChangeSuccess', function(event, current, prev) {
            $rootScope.page.setTitle(current.$$route.title || "Default");
        });
    }
]);