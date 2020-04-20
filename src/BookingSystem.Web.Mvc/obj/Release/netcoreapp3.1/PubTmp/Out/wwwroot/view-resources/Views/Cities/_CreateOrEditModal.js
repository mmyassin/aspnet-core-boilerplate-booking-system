(function ($) {
    app.modals.CreateOrEditCityModal = function () {

        var _citiesService = abp.services.app.cities;

        var _modalManager;
        var _$cityInformationForm = null;

		

        this.init = function (modalManager) {
            _modalManager = modalManager;

			var modal = _modalManager.getModal();

            _$cityInformationForm = _modalManager.getModal().find('form[name=CityInformationsForm]');
            _$cityInformationForm.validate();
        };

		  

        this.save = function () {
            if (!_$cityInformationForm.valid()) {
                return;
            }

            var city = _$cityInformationForm.serializeFormToObject();
			
			 _modalManager.setBusy(true);
			 _citiesService.createOrEdit(
				city
			 ).done(function () {
               abp.notify.info(app.localize('SavedSuccessfully'));
               _modalManager.close();
               abp.event.trigger('app.createOrEditCityModalSaved');
			 }).always(function () {
               _modalManager.setBusy(false);
			});
        };
    };
})(jQuery);