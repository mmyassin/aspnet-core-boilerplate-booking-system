(function ($) {
    app.modals.CreateOrEditJetModal = function () {

        var _jetsService = abp.services.app.jets;

        var _modalManager;
        var _$jetInformationForm = null;

		

        this.init = function (modalManager) {
            _modalManager = modalManager;

			var modal = _modalManager.getModal();

            _$jetInformationForm = _modalManager.getModal().find('form[name=JetInformationsForm]');
            _$jetInformationForm.validate();
        };

		  

        this.save = function () {
            if (!_$jetInformationForm.valid()) {
                return;
            }

            var jet = _$jetInformationForm.serializeFormToObject();
			
			 _modalManager.setBusy(true);
			 _jetsService.createOrEdit(
				jet
			 ).done(function () {
               abp.notify.info(app.localize('SavedSuccessfully'));
               _modalManager.close();
               abp.event.trigger('app.createOrEditJetModalSaved');
			 }).always(function () {
               _modalManager.setBusy(false);
			});
        };
    };
})(jQuery);