angular.module('JobTipsApp.Topic').config(['$routeProvider',
  function ($routeProvider) {
      $routeProvider.
        when('/home', {
            templateUrl: '../../topics/html/TopicList.html',
            controller: 'topicController'
        }).
        when('/newAccount', {
            templateUrl: '../../topics/html/NewAccount.html',
            controller: 'topicController'
        }).
        when('/newTopic', {
            templateUrl: '../../topics/html/NewTopic.html',
            controller: 'topicController'
        }).
         when('/topicDetails', {
             templateUrl: '../../topics/html/Topic.html',
             controller: 'topicController'
         }).otherwise({
             redirectTo: '/home'
         }); 
  }]);