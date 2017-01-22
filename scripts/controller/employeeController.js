(function () {
    'use strict';

    angular
        .module('HRApp')
        .controller('employeeController', employeeController);


    employeeController.$inject = ['$scope', 'Employee'];

    function employeeController($scope, Employee) {
        $scope.employees = Employee.query();
    }

})();

