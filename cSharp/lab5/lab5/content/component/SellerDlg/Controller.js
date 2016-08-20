(function (angular) {
  'use strict';

  function Controller() {
    var self = this;
   
    self.onSubmitClick = function() {
      console.log(self.seller);
      self.submiteCb(self.seller);
    }
  };

  app.component('sellerDlg', {
    templateUrl: 'content/component/SellerDlg/Template.html',
    controller: Controller,
    bindings: {
      seller: '=',
      submiteCb: '=',
      isValid: '='
    }
  });
})(window.angular)
