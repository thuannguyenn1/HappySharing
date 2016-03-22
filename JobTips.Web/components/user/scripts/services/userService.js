angular.module('JobTipsApp.User').factory('userService',['$http', function ($http) {

    var returnService = {
        
        login: function(userInfo, onSuccess, onFail) {
            var url = JT.globalValues.defaultPath + 'User/Login';
            $http.post(url,userInfo).then(onSuccess, onFail);
        }

    };
    return returnService;
}]);