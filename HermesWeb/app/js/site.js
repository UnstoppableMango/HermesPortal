var app = angular.module('HermesPortal', [
    'ngRoute'
]);

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

var buildConfig = "dev";

var serviceBase;
if (buildConfig == "dev") {
    serviceBase = "http://localhost:6953";
}
else if (buildConfig == "prod") {
    serviceBase = "http://localhost:5000";
}

app.constant('serviceSettings', {
    apiServiceBaseUri: serviceBase
});