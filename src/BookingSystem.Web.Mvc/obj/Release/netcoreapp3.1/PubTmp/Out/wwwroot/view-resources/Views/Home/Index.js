(function () {
    $(function () {
        var _$flightsTable = $('#FlightsTable');
        var _flightsService = abp.services.app.flights;

        var _permissions = {
            create: abp.auth.hasPermission('Pages.Flights.Create'),
            edit: abp.auth.hasPermission('Pages.Flights.Edit'),
            'delete': abp.auth.hasPermission('Pages.Flights.Delete'),
            book: abp.auth.hasPermission('Pages.Flights.Book'),
        };

        var _createOrEditModal = new app.ModalManager({
            viewUrl: abp.appPath + 'Flights/CreateOrEditModal',
            scriptUrl: abp.appPath + 'view-resources/Views/Flights/_CreateOrEditModal.js',
            modalClass: 'CreateOrEditFlightModal'
        });

        var _viewFlightModal = new app.ModalManager({
            viewUrl: abp.appPath + 'Flights/ViewflightModal',
            modalClass: 'ViewFlightModal'
        });

        function getToday() {
            let data = new Date();
            let day = data.getDate();
            let month = data.getMonth();
            let year = data.getFullYear();

            return new Date(year, month, day, 0, 0, 0);
        }
        var dataTable = _$flightsTable.DataTable({
            paging: false,
            serverSide: true,
            processing: false,
            responsive: true,
            listAction: {
                ajaxFunction: _flightsService.getAll,
                inputFilter: function () {
                    return {
                        filter: '',
                        departureDateFilter: getToday(),
                        arrivalDateFilter: '',
                        statusFilter: -1,
                        cityNameFilter: '',
                        cityName2Filter: '',
                        jetJetTypeFilter: ''
                    };
                }
            },
            buttons: [],

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
                        items: [
                            {
                                text: app.localize('View'),
                                action: function (data) {
                                    _viewFlightModal.open({ id: data.record.flight.id });
                                }
                            },
                            {
                                text: app.localize('Edit'),
                                visible: function () {
                                    return _permissions.edit;
                                },
                                action: function (data) {
                                    _createOrEditModal.open({ id: data.record.flight.id });
                                }
                            },
                            {
                                text: app.localize('Delete'),
                                visible: function () {
                                    return _permissions.delete;
                                },
                                action: function (data) {
                                    deleteFlight(data.record.flight);
                                }
                            },
                            {
                                text: app.localize('Book'),
                                visible: function () {
                                    return _permissions.book;
                                },
                                action: function (data) {
                                    _bookFlightModal.open({ id: data.record.flight.id });
                                }
                            }]
                    }
                }, {
                    targets: 1,
                    data: "flight.status",
                    name: "status",
                    render: function (status) {
                        return app.localize('Enum_FlightStatus_' + status);
                    },
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
                    data: "flight.arrivalDate",
                    name: "arrivalDate",
                    render: function (arrivalDate) {
                        if (arrivalDate) {
                            return moment(arrivalDate).format('L LT');
                        }
                        return "";
                    },

                },
                {
                    targets: 7,
                    data: "flight.economySeats",
                    name: "economySeats",
                },
                {
                    targets: 8,
                    data: "flight.businessSeats",
                    name: "businessSeats",
                },
                {
                    targets: 9,
                    data: "flight.economyPrice",
                    name: "economyPrice",
                },
                {
                    targets: 10,
                    data: "flight.businessPrice",
                    name: "businessPrice",
                },
                {
                    targets: 11,
                    data: "jetJetType",
                    name: "jetFk.jetType",
                },
                {
                    targets: 12,
                    data: "businessAvailableTickets",
                },
                {
                    targets: 13,
                    data: "economyAvailableTickets",
                }
            ]
        });

        function getFlights() {
            dataTable.ajax.reload();
        }

        function deleteFlight(flight) {
            abp.message.confirm(
                '',
                app.localize('AreYouSure'),
                function (isConfirmed) {
                    if (isConfirmed) {
                        _flightsService.delete({
                            id: flight.id
                        }).done(function () {
                            getFlights(true);
                            abp.notify.success(app.localize('SuccessfullyDeleted'));
                        });
                    }
                }
            );
        }

        abp.event.on('app.createOrEditFlightModalSaved', function () {
            getFlights();
        });

        $('#GetFlightsButton').click(function (e) {
            e.preventDefault();
            getFlights();
        });
    });
})();
