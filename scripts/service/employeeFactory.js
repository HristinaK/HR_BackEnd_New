(function () {
    'use strict';

    angular
        .module('HRApp')
        .factory('employeeFactory', employeeFactory);

    employeeFactory.$inject = ['$http'];

    function employeeFactory($http) {
        var service = {
            getData: getData
        };

        return service;

        function getData() {
            return $http.get('/api/employee');
        }
    }
})();