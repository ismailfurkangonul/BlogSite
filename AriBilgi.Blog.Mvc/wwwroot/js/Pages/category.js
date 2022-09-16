var app = angular.module('categoryapp', []);
app.controller("categorycontroller", function ($scope, $http) {

    angular.element(document).ready(function () {

       


    });
    $scope.AddCategory = function () {
        $http({

            method: "POST",
            url: "/Category/AddCategory",
            data: $scope.Category
        }).then(function (d) {
            if (d.date) {

                alert("kategori başarıyla eklendi");

            }
            else {

                alert("kategori eklendi");

            }

        });

    }

   


});