﻿(function() {
    angular
        .module("gallery")
        .controller("galleryController", ["repository", galleryController]);

    function galleryController(repository) {
        
        // store 'this' to a variable to prevent side effect of closure
        var controller = this;

        // set default values
        controller.search = '';
        controller.order = 'asc';
        
        //action methods
        controller.changeOrder = function() {
            if (controller.order === 'asc') controller.order = 'desc';
            else controller.order = 'asc';
            //Fetch list again to reorder
            if (controller.search) {
                controller.doSearch();
            } else {
                controller.defaultListing();
            }
        };

        controller.doSearch = function() {
            //Reset result message
            controller.result = '';

            repository.query({ order: controller.order, search: controller.search },
                function(data) {
                    controller.images = data;
                },
                function(response) {
                    //Get status message
                    if (response.data != null) {
                        controller.result = response.data.message + "\r\n";
                    }
                });
        };

        controller.defaultListing = function() {
            repository.query({ order: controller.order },
                function(data) {
                    controller.images = data;
                });
        };

        // show list for initial access
        controller.defaultListing();
    }
}());