'use strict';
app.directive('ngScrollbar', [function () {
    return {
        restrict: 'A',
        scope: {
            'model': '='
        },
        link: function (scope, elem, attrs) {
            elem.mCustomScrollbar({
                theme: attrs.ngsbTheme,
                axis: attrs.ngsbAxis,
                advanced: {

                },
                callbacks: {
                    onCreate: function () {
                        
                    }
                }
            });
        }
    };
}]);