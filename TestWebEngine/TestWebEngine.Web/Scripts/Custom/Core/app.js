"use strict";

var appName = "Home";

var homeApp = angular.module("homeApp", [
    "ngRoute",
    "homeControllers",
    "testControllers"
]);

homeApp.config([
    '$routeProvider',
    function($routeProvider) {
        $routeProvider
            .when('/', {
                title: 'Index Page',
                templateUrl: '/Home/Index/',
                controller: 'HomeCtrl',
                controllerName: "Home"
            })
            .when('/Home/Next', {
                title: 'Next Page',
                templateUrl: '/Home/Next/',
                controller: 'StartCtrl',
                controllerName: "Home"
            })
            .when('/Test/Index/', {
                title: 'Test Page',
                templateUrl: '/Test/Index/',
                controller: 'TestCtrl',
                controllerName: "Test"
            })
            .otherwise({
                redirectTo: '/'
            });
    }
]);

homeApp.run(['$rootScope', function($rootScope) {
        $rootScope.page = {
            setTitle: function(title, name) {
                this.title = name + ' | ' + title;
            },
            links: [
                { name: 'Index Page', path: '/Home/Index/' },
                { name: 'Next Page', path: '/Home/Next/' },
                { name: 'Test Page', path: '/Test/Index/' }
            ]
        };

        $rootScope.$on('$routeChangeSuccess', function(event, current, prev) {
            $rootScope.page.setTitle(current.$$route.title || "Default", current.$$route.controllerName || "Default");
        });
    }
]);