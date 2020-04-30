(function ($) {
    app.modals.CreateOrEditFlightModal = function () {

        var _flightsService = abp.services.app.flights;

        var _modalManager;
        var _$flightInformationForm = null;

        var _FlightcityLookupTableModal = new app.ModalManager({
            viewUrl: abp.appPath + 'Flights/CityLookupTableModal',
            scriptUrl: abp.appPath + 'view-resources/Views/Flights/_FlightCityLookupTableModal.js',
            modalClass: 'CityLookupTableModal'
        });
        var _FlightjetLookupTableModal = new app.ModalManager({
            viewUrl: abp.appPath + 'Flights/JetLookupTableModal',
            scriptUrl: abp.appPath + 'view-resources/Views/Flights/_FlightJetLookupTableModal.js',
            modalClass: 'JetLookupTableModal'
        });

        this.init = function (modalManager) {
            _modalManager = modalManager;

            var modal = _modalManager.getModal();
            modal.find('.date-picker').datetimepicker({
                locale: abp.localization.currentLanguage.name,
                format: 'L LT'
            });

            _$flightInformationForm = _modalManager.getModal().find('form[name=FlightInformationsForm]');
            _$flightInformationForm.validate();
        };

        $('#OpenCityLookupTableButton').click(function () {

            var flight = _$flightInformationForm.serializeFormToObject();

            _FlightcityLookupTableModal.open({ id: flight.locationOfDepartureId, displayName: flight.cityName }, function (data) {
                _$flightInformationForm.find('input[name=cityName]').val(data.displayName);
                _$flightInformationForm.find('input[name=locationOfDepartureId]').val(data.id);
            });
        });

        $('#ClearCityNameButton').click(function () {
            _$flightInformationForm.find('input[name=cityName]').val('');
            _$flightInformationForm.find('input[name=locationOfDepartureId]').val('');
        });

        $('#OpenCity2LookupTableButton').click(function () {

            var flight = _$flightInformationForm.serializeFormToObject();

            _FlightcityLookupTableModal.open({ id: flight.locationOfArrivalId, displayName: flight.cityName2 }, function (data) {
                _$flightInformationForm.find('input[name=cityName2]').val(data.displayName);
                _$flightInformationForm.find('input[name=locationOfArrivalId]').val(data.id);
            });
        });

        $('#ClearCityName2Button').click(function () {
            _$flightInformationForm.find('input[name=cityName2]').val('');
            _$flightInformationForm.find('input[name=locationOfArrivalId]').val('');
        });

        $('#OpenJetLookupTableButton').click(function () {

            var flight = _$flightInformationForm.serializeFormToObject();

            _FlightjetLookupTableModal.open({ id: flight.jetId, displayName: flight.jetJetType }, function (data) {
                _$flightInformationForm.find('input[name=jetJetType]').val(data.displayName);
                _$flightInformationForm.find('input[name=jetId]').val(data.id);
            });
        });

        $('#ClearJetJetTypeButton').click(function () {
            _$flightInformationForm.find('input[name=jetJetType]').val('');
            _$flightInformationForm.find('input[name=jetId]').val('');
        });



        this.save = function () {
            if (!_$flightInformationForm.valid()) {
                return;
            }
            if ($('#Flight_LocationOfDepartureId').prop('required') && $('#Flight_LocationOfDepartureId').val() == '') {
                abp.message.error(app.localize('{0}IsRequired', app.localize('City')));
                return;
            }
            if ($('#Flight_LocationOfArrivalId').prop('required') && $('#Flight_LocationOfArrivalId').val() == '') {
                abp.message.error(app.localize('{0}IsRequired', app.localize('City')));
                return;
            }
            if ($('#Flight_JetId').prop('required') && $('#Flight_JetId').val() == '') {
                abp.message.error(app.localize('{0}IsRequired', app.localize('Jet')));
                return;
            }

            var flight = _$flightInformationForm.serializeFormToObject();

            _modalManager.setBusy(true);
            _flightsService.createOrEdit(
                flight
            ).done(function () {
                abp.notify.info(app.localize('SavedSuccessfully'));
                _modalManager.close();
                abp.event.trigger('app.createOrEditFlightModalSaved');
            }).always(function () {
                _modalManager.setBusy(false);
            });
        };
    };
})(jQuery);