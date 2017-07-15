
var searchTextApp = angular.module('searchTextApp', []);

var searchTextController = function ($scope, $http) {
    $scope.Text = "";
    $scope.SubText = ""
    $scope.Output = ""
    $scope.searchText = function () {
        var config = {
            params: {
                text: $scope.Text,
                subtext: $scope.SubText
            }
        }
        $http.get("home/searchText", config).then(function (response) {
            $scope.Output = response.data;
        });
    }
}

searchTextApp.component('searchTextComponent', {
    templateUrl: '/app/searchTextcomponent.html',
    controller: searchTextController,
    controllerAs: 'vm'
});