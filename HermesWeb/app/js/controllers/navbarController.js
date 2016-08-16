'use strict';
app.controller('navbarController', ['$scope', function ($scope) {
    $('.nav.navbar-nav > li').on('click', function (e) {
        $('.nav.navbar-nav > li').removeClass('active');
        $(this).addClass('active');
    });
}]);