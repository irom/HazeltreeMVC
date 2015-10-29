app.controller('Securities', function ($scope, $http) {
    var vm =$scope;
    vm.securityCode;
    vm.securityText;

    vm.onclick = function () {
        var data = { SecurityCode:  vm.securityCode , SearchText: vm.securityText };
        $http({
              url: "/Home/FetchData/"
            , method: "GET"
            , params: data
            , contentType: "application/json; charset=utf-8",
        }).then(onComplete, onError);


        
    }

    var onComplete = function (response) {
     
        console.log(response);
        vm.result = response.data;
    };

    var onError = function (error) {
        console.log(error);
    };

    
});