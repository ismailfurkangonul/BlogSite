var app = angular.module('articleapp', []);
app.controller("articlecontroller", function ($scope, $http) {

    angular.element(document).ready(function () {
        $scope.GetCategoryList();
       
    });

    $scope.AddArticle = function () {
        $http({

            method: "POST",
            url: "/Article/AddArticle",
            data: $scope.Article
        }).then(function (d) {
            if (d.date) {

                alert("makale başarıyla eklendi");

            }
            else {

                alert("makale eklenemedi");

            }

        });

    }

    $scope.GetCategoryList = function () {
        $http({

            method: "POST",
            url: "/Article/GetCategoryList"

        }).then(function (d) {

            $scope.CategoryList = d.data;
            

        });

    }

  



});