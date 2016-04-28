(function () {
    angular
        .module("gallery")
        .controller("galleryController", ["repository", galleryController]);
    
    function galleryController(repository) {

        var controller = this;
        
        repository.query(function (data) {
            controller.images = data;
        });
    }
}());