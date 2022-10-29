(function (angular) {
    "use strict";

    angular
        .module("todoApp")
        .controller("pagination", pagination);

    function pagination($scope, todoPaginatedListService) {
        $scope.gotoPage = gotoPage;
        $scope.updatePageSize = updatePageSize;

        function updatePageSize() {
            $scope.queryParams.currentPage = 1;

            // Call the service.js with the queryParams to get the result and render the HTML with the data
        }

        function gotoPage(page) {
            if (!page) { return; }

            if (page <= 0 || page > $scope.todo.totalPages) { return; }

            $scope.queryParams.currentPage = page;

            // Call the service.js with the queryParams to get the result and render the HTML with the data
        }
    }

})(angular);