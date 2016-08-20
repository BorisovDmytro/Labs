(function () {
    'use strict';

    angular.module('App')
           .factory('SellerService', SellerService);

    SellerService.$inject = ['$http'];

    function SellerService($http) {
      var sellers = [];
      
      var service = {
        get: get,
        create: create,
        update: update,
        remove: remove
      };

      return service;

      function get(cb) {
        $http({
          method: "GET",
          url: "/seller"
        }).then(function (answ) {
          sellers = answ.data;
          cb(sellers);
        }, function (err) {
          cb(null);
          console.error(err);
          });
      }

      function update(seller, cb) {
        $http({
          method: "POST",
          url: "/seller",
          params: {
            Id: seller.Id,
            Name: seller.Name,
            SecondName: seller.SecondName,
            Age: seller.Age.toString()
          }
        }).then(function (answ) {
          cb(null);
        }, function (err) {
          cb(err);
        });
      }

      function create(seller, cb)
      {
        $http({
          method: "PUT",
          url: "/seller",
          params: {
            Name: seller.Name,
            SecondName: seller.SecondName,
            Age: seller.Age.toString()
          }
        }).then(function (answ) {
          cb(null);
        }, function (err) {
          cb(err);
        });
      }

      function remove(id, cb)
      {
        $http({
          method: "DELETE",
          url: "/seller",
          params: {
            Id: id
          }
        }).then(function (answ) {
          cb(null);
        }, function (err) {
          cb(err);
        });
      }
    }
})();