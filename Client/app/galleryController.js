(function() {
    angular
        .module("gallery")
        .controller("galleryController", ["repository", galleryController]);

    function galleryController(repository) {

        var controller = this;

        controller.search = '';

        controller.doSearch = function () {
            //Reset result message
            controller.result = '';
            repository.query({ search: controller.search },
                function (data) {
                controller.images = data;
                },
            function (response) {
                //Get status message
                controller.result = response.data.message + "\r\n";
            });
        };       
       
        repository.query( function(data) {
            controller.images = data;
        });


    }
}());