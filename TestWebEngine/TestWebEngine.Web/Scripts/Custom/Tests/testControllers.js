"use strict";

var testControllers = angular.module("testControllers", []);

testControllers.controller('TestCtrl', ['$scope',
  function ($scope) {
      $scope.message = "This is a test page!";
      $scope.tests = [
          {
              name: 'test 1',
              questions: [],
              complexity: 'Low'
          },
          {
              name: 'ssdsa 1',
              questions: [1,3],
              complexity: 'Low'
          }
      ];
  }]);