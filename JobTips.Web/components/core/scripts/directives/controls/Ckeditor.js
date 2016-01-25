﻿angular.module('JobTipsApp.controls', [])
.controller('CkeditorCtrl', ['$scope', function ($scope) {

    var codemirrorConfig = {

        // Set this to the theme you wish to use (codemirror themes)
        theme: 'default',

        // Whether or not you want to show line numbers
        lineNumbers: true,

        // Whether or not you want to use line wrapping
        lineWrapping: true,

        // Whether or not you want to highlight matching braces
        matchBrackets: true,

        // Whether or not you want tags to automatically close themselves
        autoCloseTags: true,

        // Whether or not you want Brackets to automatically close themselves
        autoCloseBrackets: true,

        // Whether or not to enable search tools, CTRL+F (Find), CTRL+SHIFT+F (Replace), CTRL+SHIFT+R (Replace All), CTRL+G (Find Next), CTRL+SHIFT+G (Find Previous)
        enableSearchTools: true,

        // Whether or not you wish to enable code folding (requires 'lineNumbers' to be set to 'true')
        enableCodeFolding: true,

        // Whether or not to enable code formatting
        enableCodeFormatting: true,

        // Whether or not to automatically format code should be done when the editor is loaded
        autoFormatOnStart: true,

        // Whether or not to automatically format code should be done every time the source view is opened
        autoFormatOnModeChange: true,

        // Whether or not to automatically format code which has just been uncommented
        autoFormatOnUncomment: true,

        // Define the language specific mode 'htmlmixed' for html including (css, xml, javascript), 'application/x-httpd-php' for php mode including html, or 'text/javascript' for using java script only
        mode: 'htmlmixed',

        // Whether or not to show the search Code button on the toolbar
        showSearchButton: true,

        // Whether or not to show Trailing Spaces
        showTrailingSpace: true,

        // Whether or not to highlight all matches of current word/selection
        highlightMatches: true,

        // Whether or not to show the format button on the toolbar
        showFormatButton: true,

        // Whether or not to show the comment button on the toolbar
        showCommentButton: true,

        // Whether or not to show the uncomment button on the toolbar
        showUncommentButton: true,

        // Whether or not to show the showAutoCompleteButton button on the toolbar
        showAutoCompleteButton: true,
        // Whether or not to highlight the currently active line
        styleActiveLine: true
    };
    // Editor options.
    $scope.options = {
        language: 'en',
        allowedContent: true,
        entities: false,
        extraPlugins: 'codemirror',
        codemirror: codemirrorConfig,
        format_tags: 'Formatted;Body;Code',
        format_Formatted: { element: 'h2', name: 'Heading', attributes: { 'style': 'color:red' } },
        format_Body: { element: 'p', name: 'Body' },
        format_Code: { element: 'pre', name: 'Code Container', attributes: { 'style': 'background-color:#ffffef; border:1px #fc6 solid;border-radius: 3px' } }
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