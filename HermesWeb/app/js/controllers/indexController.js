'use strict';
app.controller('indexController', ['$scope', function ($scope) {
    $scope.loading = true;

    $(document).ready(function () {
        $scope.loading = false;
    });

    //$(window).load(function () {
    //    $("#content").mCustomScrollbar({
    //        theme: "minimal",
    //        axis: "y"
    //    });
    //})

    $('.nav.navbar-nav > li').on('click', function (e) {
        $('.nav.navbar-nav > li').removeClass('active');
        $(this).addClass('active');
    });
}]);