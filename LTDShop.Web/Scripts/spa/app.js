/// <reference path="../plugins/angular/angular.js" />

var myApp = angular.module('myModule', []);

////cách khai báo một controller
//myApp.controller("studentController", studentController);

//myApp.controller("TeacherController", teacherController)

//myApp.controller("schoolController", schoolController)
////myController.$inject = ['$scope'];



//// khai báo declare , school là dùng $scope lồng nhau 
//function schoolController($scope) {
//    $scope.message ="Anouncement from school ."
//}
//function studentController($scope) {
//   /* $scope.message = "this is my message from Controller";*/

//}
//function teacherController($scope) {
//   /* $scope.message = "this is my message from Teacher";*/
//}


myApp.controller = ("schoolController", schoolController);
myApp.service('Validator', Validator);

schoolController.$inject = ['$scope', 'Validator'];

function schoolController($scope, Validator) {
     Validator.checkNumber(1);
}
// khai báo sử dụng Services 
function Validator($window) {
    return {
        checkNumber: checkNumber
    }
    function checkNumber(input) {
       
        if (input % 2 == 0) {
            $window.alert('This is even');
        }
        else
            $window.alert('This is old');
    }
}