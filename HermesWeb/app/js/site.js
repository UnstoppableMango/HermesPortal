var app = angular.module('HermesPortal', ['ngRoute']);

app.config(function ($routeProvider) {
    $routeProvider.when("/dash", {
        controller: "dashController",
        templateUrl: "/app/views/dashboard.html",
        activateTab: 'dashboard'
    });
    $routeProvider.when("/destiny", {
        controller: "destinyController",
        templateUrl: "/app/views/destiny.html",
        activateTab: 'dashboard'
    });

    $routeProvider.otherwise({ redirectTo: "/dash" });
});