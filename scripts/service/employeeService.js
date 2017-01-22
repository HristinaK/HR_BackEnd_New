(function () {
    'use strict';

    angular
        .module('app')
        .factory('employeeService', employeeService);

    employeeService.$inject = ['$http'];

    function employeeService($http) {
        var service = {
            getData: getData
        };

        return service;

        function getData() { }
    }
})();


(function () {
    'use strict';

    var employeeService = angular.module('employeeService', ['ngResource']);

    employeeService.factory('Employee', ['$resource', function ($resource) {
        return $resource('/api/employee/:id');
    }]);

})();