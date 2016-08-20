(function (angular) {
  'use strict';

  function Controller(SellerService, ProductService) {
    var self = this;

    var selectedSeller = null;
    var selectedProducts = null;

    self.init = function () {
      SellerService.get(function (sellers) {
        self.sellers = sellers;
      });

      self.seller = {
        Id: "",
        Name: "",
        SecondName: "",
        Age: ""
      }
    }

    self.onSellerClick = function (seller) {
      self.sellerValid = true;
      self.productValid = true;
      if (selectedSeller)
        selectedSeller.isSelected = false;
      seller.isSelected = true;
      selectedSeller = seller;

      ProductService.get(seller.Id, function (products) {
        selectedProducts = null;
        self.products = products;
      });
    }

    self.onProductClick = function (product) {
      if (selectedProducts)
        selectedProducts.isSelected = false;
      selectedProducts = product;
      product.isSelected = true;
      self.productValid = true;
    }

    self.onRemoveSeller = function () {
      if (!selectedSeller) {
        alert("No selected iteam");
        return;
      } 
      SellerService.remove(selectedSeller.Id, function () {
        SellerService.get(function (sellers) {
          self.sellers = sellers;
        });
      });
    }

    self.onCreateSeller = function () {
      self.sellerValid = true;
      self.SellerDlgCb = function (seller) {
        self.seller = {
          Id: "",
          Name: "",
          SecondName: "",
          Age: ""
        };
        SellerService.create(seller, function () {
          SellerService.get(function (sellers) {
            self.sellers = sellers;
          });
        });
      }
    }

    self.onUpdateSeller = function () {
      self.seller = selectedSeller;
      if (!selectedSeller) {
        self.sellerValid = false;
        return;
      }
      self.SellerDlgCb = function (seller) {
        SellerService.update(seller, function () {
          SellerService.get(function (sellers) {
            self.sellers = sellers;
          });
        });
      }
    }

    self.onAddProduct = function () {
      self.product = selectedProducts;
      if (!selectedSeller) {
        self.productValid = false;
        return;
      }       

      self.ProductDlgCb = function (product) {
        ProductService.create(product, selectedSeller.Id, function () {
          ProductService.get(selectedSeller.Id,
          function (products) {
            self.products = products;
          });
        });
      }
    }

    self.onUpdateProduct = function () {
      if (!selectedProducts) {
        self.productValid = false;
        return;
      }
      self.product = selectedProducts;
      self.ProductDlgCb = function (product) {
        ProductService.update(self.product, function () {
          ProductService.get(self.seller.Id, function (products) {
            selectedProducts = self.product;
            self.products = products;
          });
        });
      }
    }

    self.onRemoveProduct = function () {
      if (!selectedProducts) {
        alert("First selected seller");
        return;
      }
      ProductService.remove(selectedProducts.Id, function () {
        ProductService.get(self.seller.Id, function (products) {
          selectedProducts = null;
          self.products = products;
        });
      });
    }
  };

  app.component('mainView', {
    templateUrl: 'content/component/MainView/Template.html',
    controller: Controller,
  });
})(window.angular)
