'use strict';
app.factory('dashService', ['$http', 'serviceSettings', function ($http, serviceSettings) {
    var serviceBase = serviceSettings.apiServiceBaseUri;

    var dashServiceFactory = {};

    var _getDestinyRss = function (ul) {
        var dnewsfrag = document.createDocumentFragment();
        var destinyRss = [];

        return $http.get(serviceBase + '/api/Destiny/News', {
            headers: { 'Content-Type': 'application/json' }
        }).then(function (results) {
            destinyRss = results.data;
            destinyRss.forEach(function (e) {
                var li = document.createElement("li");
                var a = document.createElement("a");
                var h3 = document.createElement("h3");
                var p = document.createElement("p");
                var span = document.createElement("span");

                a.setAttribute('href', e.link);
                a.setAttribute('target', '_blank');
                h3.textContent = e.title;
                p.textContent = e.description;
                span.textContent = e.publishDate;

                li.appendChild(a);
                li.appendChild(h3);
                li.appendChild(span);
                li.appendChild(p);
                dnewsfrag.appendChild(li);
            })
            ul.appendChild(dnewsfrag);
        });
    };

    dashServiceFactory.GetDestinyRss = _getDestinyRss;
    return dashServiceFactory;
}]);