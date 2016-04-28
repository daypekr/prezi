(function() {
    angular
        .module("gallery")
        .controller("galleryController", ["repository", galleryController]);

    function galleryController(repository) {

        var controller = this;

        controller.search = '';
        controller.order = 'asc';
        controller.changeOrder = function() {
            if (controller.order === 'asc') controller.order = 'desc';
            else controller.order = 'asc';
            //Fetch list again to reorder
            controller.defaultListing();
        };

        controller.doSearch = function () {
            //Reset result message
            controller.result = '';
            
            repository.query({ order:controller.order,search: controller.search },
                function (data) {
                controller.images = data;
                },
            function (response) {
                //Get status message
                controller.result = response.data.message + "\r\n";
            });
        };

        controller.defaultListing = function() {
            repository.query({ order: controller.order },
                function (data) {
                    controller.images = data;
                });
        };

        controller.defaultListing();
    }
}());