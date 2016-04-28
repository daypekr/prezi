(function () {
/*
    service to handle interaction with backend service.
    To get the code simple, $resource plugin is used.
*/
    "use strict";

    angular
        .module("services")
        .factory("repository", ["$resource", repository]);
    
    function repository($resource) {
        return $resource("http://localhost:25126/api/gallery");
    }
    
}());