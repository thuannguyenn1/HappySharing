angular.module('JobTipsApp.User', []).controller('userController',['$scope', 'userService',function ($scope, userService) {

   var init = function() {
        
       $scope.login = function() {
           userService.login($scope.userInfo,
               function (data) {
                   alert(JSON.stringify(data.data));
               },
               function(error) {
                   
               }
           );
       }

   }
    init();
}]).directive('login', function() {

    return {
        restrict: 'E',
        templateUrl: '../../user/html/LoginForm.html',
        controller: 'userController'
    };

});