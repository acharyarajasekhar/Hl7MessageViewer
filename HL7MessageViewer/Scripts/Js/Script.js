/// <reference path="../angular.min.js" />
var app = angular.module("hl7MsgVwr", []);

app.factory("hl7MsgSvc", function ($http) {
    var result;


});

app.controller("hl7MsgCtrl", function ($scope, $rootScope, $http, $log, $anchorScroll, $location) {

    $scope.OnFormSubmit = function () {

        $rootScope.Server = $scope.Server;
        $rootScope.NameSpace = $scope.NameSpace;
        $rootScope.PasID = $scope.PasID;

        $scope.Loading++;

        $http({
            url: "api/Hl7Api",
            method: "GET",
            params: {
                server: $scope.Server,
                ns: $scope.NameSpace,
                pasid: $scope.PasID
            }
        })
            .success(function (response, status, headers, config) {
                $scope.MsgIDs = response;
                $scope.Error = "";
                $log.info(response);
                $scope.Loading--;
            })
            .error(function (response, status, headers, config) {
                $scope.Error = response.ExceptionMessage;
                $log.error(response);
                $scope.Loading--;
            });

    };

    $scope.OnMsgIDClick = function (msgID) {
        $scope.CurrentMessageID = msgID;
        $scope.Loading++;
        $http({
            url: "api/Hl7Api",
            method: "GET",
            params: {
                url: ""
            }
        }).success(function (response, status, headers, config) {
            $scope.HL7MsgSegments = response;
            $scope.Error = "";
            $log.info(response);
            $scope.Loading--;
        }).error(function (response, status, headers, config) {
            $scope.Error = response.ExceptionMessage;
            $log.error(response);
            $scope.Loading--;
        });
    };

    $scope.Server = "";
    $scope.NameSpace = "";
    $scope.PasID = "";
    $scope.Error = "";
    $scope.CurrentMessageID = "";
    $scope.Loading = 0;
});