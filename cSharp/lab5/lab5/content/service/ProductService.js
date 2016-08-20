(function () {
  'use strict';

  angular.module('App')
         .factory('ProductService', ProductService);

  ProductService.$inject = ['$http'];

  function ProductService($http) {
    var products = [];

    var service = {
      get: get,
      create: create,
      update: update,
      remove: remove
    };

    return service;

    function get(id, cb) {
      $http({
        method: "GET",
        url: "/product",
        params: {
          'seller': id
        }
      }).then(function (answ) {
        products = answ.data;
        cb(products);
      }, function (err) {
        cb(null);
        console.error(err);
      });
    }

    function create(product, id, cb) {
      $http({
        method: "PUT",
        url: "/product",
        params: {
          Name: product.Name,
          Manufacturer: product.Manufacturer,
          Price: product.Price,
          Seller: id
        }
      }).then(function (answ) {
        cb();
      }, function (err) {
        cb(null);
        console.error(err);
      });
    }

    function update(product, cb) {
      $http({
        method: "POST",
        url: "/product",
        params: {
          Id: product.Id,
          Name: product.Name,
          Manufacturer: product.Manufacturer,
          Price: product.Price
        }
      }).then(function (answ) {
        cb();
      }, function (err) {
        cb(null);
        console.error(err);
      });
    }

    function remove(id, cb) {
      $http({
        method: "DELETE",
        url: "/product",
        params: {
          Id: id
        }
      }).then(function (answ) {
        cb();
      }, function (err) {
        cb(null);
        console.error(err);
      });
    }
  }
})();