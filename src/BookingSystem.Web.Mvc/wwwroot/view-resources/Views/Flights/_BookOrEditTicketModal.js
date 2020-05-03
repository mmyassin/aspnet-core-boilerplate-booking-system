(function ($) {
    app.modals.BookOrEditTicketModal = function () {

        var _flightsService = abp.services.app.flights;

        var _modalManager;
        var _$ticketInformationForm = null;


        this.init = function (modalManager) {
            _modalManager = modalManager;

            var modal = _modalManager.getModal();
            modal.find('.date-picker').datetimepicker({
                locale: abp.localization.currentLanguage.name,
                format: 'L LT'
            });

            _$ticketInformationForm = _modalManager.getModal().find('form[name=TicketInformationsForm]');

            _$ticketInformationForm.validate();
        };

       
        $('#Ticket_Class').change(function () {
            var ticket = _$ticketInformationForm.serializeFormToObject();
            if (ticket.class === '2') {
                $('#Ticket_Price').val(ticket.businessPrice);
            } else {
                $('#Ticket_Price').val(ticket.economyPrice);
            }
        });

        if ($("#Ticket_IsPaid").is(":checked")) {
            $("#paymentDetails").show();
        } else {
            $("#paymentDetails").hide();
        }

        $('#Ticket_IsPaid').click(function (e) {
            var checked = $(this).is(":checked")
            if (checked) {
                $("#paymentDetails").show();
            } else {
                $("#paymentDetails").hide();
            }
        });

        this.save = function () {
            if (!_$ticketInformationForm.valid()) {
                return;
            }
            if ($('#Passenger_Full_Name').prop('required') && $('#Passenger_Full_Name').val() == '') {
                abp.message.error(app.localize('{0} Is Required', app.localize('Passenger_Full_Name')));
                return;
            }

            if ($('#Ticket_IsPaid').is(':checked') && $('#CardNumber').val() == '') {
                abp.message.error(app.localize('{0} Is Required', app.localize('CardNumber')));
                return;
            }

            if ($('#Ticket_IsPaid').is(':checked') && $('#CVV').val() == '') {
                abp.message.error(app.localize('{0} Is Required', app.localize('CVV')));
                return;
            }

            if ($('#Ticket_IsPaid').is(':checked') && $('#Expiry').val() == '') {
                abp.message.error(app.localize('{0} Is Required', app.localize('Expiry')));
                return;
            }

            var ticket = _$ticketInformationForm.serializeFormToObject();

            _modalManager.setBusy(true);
            _flightsService.bookOrEditTicket(
                ticket
            ).done(function () {
                abp.notify.info(app.localize('SavedSuccessfully'));
                _modalManager.close();
                abp.event.trigger('app.bookOrEditTicketModalSaved');
            }).always(function () {
                _modalManager.setBusy(false);
            });
        };
    };
})(jQuery);