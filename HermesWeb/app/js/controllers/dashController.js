'use strict';
app.controller('dashController', ['$scope', 'dashService', function ($scope, dashService) {

    $scope.dnews = {
        scrollbar: {

        }
    };

    var ul = document.getElementById("destiny-news").getElementsByTagName("ul")[0];
    $scope.dloading = true;
    dashService.GetDestinyRss(ul).then(function () {
        $("#destiny-news").find(".widget-loading").css({ "visibility": "hidden", "opacity": "0" });
    })
}]);