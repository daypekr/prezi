(function() {
    angular
        .module("gallery")
        .controller("galleryController", ["repository", galleryController]);

    function galleryController(repository) {

        var controller = this;

        controller.search = '';

        controller.doSearch = function () {
            alert(controller.search);
            repository.query({ search: controller.search }, function(data) {
                controller.images = data;
            });
        };       
       
        repository.query( function(data) {
            controller.images = data;
        });


    }
}());