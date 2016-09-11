'use strict';
app.controller('indexController', ['$scope', function ($scope) {
    $scope.loading = true;

    $(document).ready(function () {
        $scope.loading = false;
    });

    $('.nav.navbar-nav > li').on('click', function (e) {
        $('.nav.navbar-nav > li').removeClass('active');
        $(this).addClass('active');
    });
}]);