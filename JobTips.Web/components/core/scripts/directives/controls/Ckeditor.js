angular.module('JobTipsApp.controls', [])
.controller('CkeditorCtrl', ['$scope', function ($scope) {

    // Editor options.
    $scope.options = {
        language: 'vn',
        allowedContent: true,
        entities: false,
        format_tags: 'Formatted;Body;Code',
        format_Formatted: { element: 'h2', name: 'Heading', attributes: { 'style': 'color:red' } },
        format_Body: { element: 'p', name: 'Body' },
        format_Code: { element: 'pre code', name: 'Code Container', attributes: { 'style': 'background-color:#ffffef; border:1px #fc6 solid;border-radius: 3px' } }
    };

    // Called when the editor is completely ready.
    $scope.onReady = function () {
        // ...
    };
}])
    .directive('ckEditor', function () {

        return {
            restrict: 'E',
            templateUrl: '../html/controls/CkEditor.html',
            controller: 'CkeditorCtrl'
        };

    });