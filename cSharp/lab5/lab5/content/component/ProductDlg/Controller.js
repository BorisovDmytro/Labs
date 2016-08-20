(function (angular) {
  'use strict';

  function Controller() {
    var self = this;

    self.onSubmitClick = function () {
      console.log(self.product);
      self.submiteCb(self.product);
    }
  };

  app.component('productDlg', {
    templateUrl: 'content/component/ProductDlg/Template.html',
    controller: Controller,
    bindings: {
      product: '=',
      submiteCb: '=',
      isValid: '='
    }
  });
})(window.angular)
