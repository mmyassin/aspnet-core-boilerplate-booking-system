(function () {
    $(function () {

        var _$ticketsTable = $('#TicketsTable');
        var _flightsService = abp.services.app.flights;

        $('.date-picker').datetimepicker({
            locale: abp.localization.currentLanguage.name,
            format: 'L'
        });

        var _permissions = {
            edit: abp.auth.hasPermission('Pages.Flights.Book'),
            cancel: abp.auth.hasPermission('Pages.Flights.Book'),
        };

        var _bookOrEditTicketModal = new app.ModalManager({
            viewUrl: abp.appPath + 'Flights/BookOrEditTicketModal',
            scriptUrl: abp.appPath + 'view-resources/Views/Flights/_BookOrEditTicketModal.js',
            modalClass: 'BookOrEditTicketModal'
        });

        var dataTable = _$ticketsTable.DataTable({
            paging: true,
            serverSide: true,
            processing: true,
            responsive: true,
            listAction: {
                ajaxFunction: _flightsService.getAllBookedTickets,
                inputFilter: function () {
                    return {
                        filter: $('#FlightsTableFilter').val(),
                        userId: abp.session.userId
                    };
                }
            },
            buttons: [
                {
                    name: 'refresh',
                    text: '<i class="fas fa-redo-alt"></i>',
                    action: () => dataTable.ajax.reload()
                }
            ],

            columnDefs: [
                {
                    width: 100,
                    targets: 0,
                    data: null,
                    orderable: false,
                    autoWidth: false,
                    defaultContent: '',
                    rowAction: {
                        cssClass: 'btn btn-brand dropdown-toggle',
                        text: '<i class="fa fa-cog"></i> ' + app.localize('Actions') + ' <span class="caret"></span>',
                        items: [{
                            text: app.localize('Edit'),
                            visible: function () {
                                return _permissions.edit;
                            },
                            action: function (data) {
                                _bookOrEditTicketModal.open({ id: data.record.ticket.id, flightId: data.record.flight.id });
                            }
                        }, {
                            text: app.localize('Cancel'),
                            visible: function () {
                                return _permissions.cancel;
                            },
                            action: function (data) {
                                cancelTicket(data.record.ticket);
                            }
                        }]
                    }
                }, {
                    targets: 1,
                    data: "ticket.ticketNumber",
                    name: "ticketNumber",
                },
                {
                    targets: 2,
                    data: "flight.flightNumber",
                    name: "flightNumber",
                },
                {
                    targets: 3,
                    data: "cityName",
                    name: "locationOfDepartureFk.name",
                },
                {
                    targets: 4,
                    data: "cityName2",
                    name: "locationOfArrivalFk.name",
                },
                {
                    targets: 5,
                    data: "flight.departureDate",
                    name: "departureDate",
                    render: function (departureDate) {
                        if (departureDate) {
                            return moment(departureDate).format('L LT');
                        }
                        return "";
                    },

                },
                {
                    targets: 6,
                    data: "ticket.isPaid",
                    name: "isPaid",
                    render: function (isPaid) {
                        if (isPaid) {
                            return '<div class="text-center"><i class="fa fa-check kt--font-success" title="True"></i></div>';
                        }
                        return '<div class="text-center"><i class="fa fa-times-circle" title="False"></i></div>';
                    }
                },
                {
                    targets: 7,
                    data: "ticket.isCanceled",
                    name: "isCanceled",
                    render: function (isCanceled) {
                        if (isCanceled) {
                            return '<div class="text-center"><i class="fa fa-check kt--font-success" title="True"></i></div>';
                        }
                        return '<div class="text-center"><i class="fa fa-times-circle" title="False"></i></div>';
                    }
                }
            ]
        });

        function getTickets() {
            dataTable.ajax.reload();
        }

        function cancelTicket(ticket) {
            abp.message.confirm(
                '',
                app.localize('AreYouSure'),
                function (isConfirmed) {
                    if (isConfirmed) {
                        _flightsService.cancelTicket({
                            id: ticket.id
                        }).done(function () {
                            getTickets(true);
                            abp.notify.success(app.localize('SuccessfullyCanceled'));
                        });
                    }
                }
            );
        }

        abp.event.on('app.bookOrEditTicketModalSaved', function () {
            getTickets();
        });


        $('#GetTicketsButton').click(function (e) {
            e.preventDefault();
            getTickets();
        });

        $(document).keypress(function (e) {
            if (e.which === 13) {
                getFlights();
            }
        });
    });
})();