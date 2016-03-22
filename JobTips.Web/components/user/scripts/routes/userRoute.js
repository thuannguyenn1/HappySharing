angular.module('JobTipsApp.User').config(['$routeProvider',
  function ($routeProvider) {
      $routeProvider.
        when('/userLogin', {
            templateUrl: '../../user/html/Login.html'
        }).
        when('/newAccount', {
            templateUrl: '../../user/html/NewAccount.html',
            controller: 'topicController'
        });
  }]);