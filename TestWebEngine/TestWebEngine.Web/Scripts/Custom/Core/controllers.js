"use strict";

var homeControllers = angular.module("homeControllers", []);

homeControllers.controller('HomeCtrl', ['$scope',
  function ($scope) {
      $scope.message = "Hello, testing of Angular!";
  }]);

homeControllers.controller('StartCtrl', ['$scope',
  function ($scope) {
      $scope.message = "Oh, I am go to next page!";
  }]);