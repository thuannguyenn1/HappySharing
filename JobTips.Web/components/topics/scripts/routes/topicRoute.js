angular.module('JobTipsApp.Topic').config(['$routeProvider',
  function ($routeProvider) {
      $routeProvider.
        when('/home', {
            templateUrl: '../../topics/html/TopicList.html',
            controller: 'TopicController'
        }).
        when('/newAccount', {
            templateUrl: '../../topics/html/NewAccount.html',
            controller: 'TopicController'
        }).
        when('/newTopic', {
            templateUrl: '../../topics/html/NewTopic.html',
            controller: 'TopicController'
        }).
         when('/topicDetails', {
             templateUrl: '../../topics/html/Topic.html',
             controller: 'TopicController'
         }).
        otherwise({
            redirectTo: '/home'
        }); 
  }]);