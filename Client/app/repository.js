(function () {
    "use strict";

    angular
        .module("services")
        .factory("repository", ["$resource", repository]);
    
    function repository($resource) {
        return $resource("http://localhost:25126/api/gallery");
    }
}());