'use strict';
app.controller('dashController', ['$scope', 'dashService', function ($scope, dashService) {

    /* initialize scrollbar */
    $(".widget-body").mCustomScrollbar({
        theme: "minimal",
        axis: "y"
    });

    var ul = document.getElementById("destiny-news").getElementsByTagName("ul")[0];
    dashService.GetDestinyRss(ul);

}]);