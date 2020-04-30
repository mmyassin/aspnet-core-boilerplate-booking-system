(function () {
    $(function () {

        var _$flightsTable = $('#FlightsTable');
        var _flightsService = abp.services.app.flights;
		
        $('.date-picker').datetimepicker({
            locale: abp.localization.currentLanguage.name,
            format: 'L'
        });

        var _permissions = {
            create: abp.auth.hasPermission('Pages.Flights.Create'),
            edit: abp.auth.hasPermission('Pages.Flights.Edit'),
            'delete': abp.auth.hasPermission('Pages.Flights.Delete')
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

		
		

        var getDateFilter = function (element) {
            if (element.data("DateTimePicker").date() == null) {
                return null;
            }
            return element.data("DateTimePicker").date().format("YYYY-MM-DDT00:00:00Z"); 
        }

        var dataTable = _$flightsTable.DataTable({
            paging: true,
            serverSide: true,
            processing: true,
            responsive: true,
            listAction: {
                ajaxFunction: _flightsService.getAll,
                inputFilter: function () {
                    return {
                        filter: $('#FlightsTableFilter').val(),
                        departureDateFilter: getDateFilter($('#DepartureDateFilterId')),
                        arrivalDateFilter: getDateFilter($('#ArrivalDateFilterId')),
                        statusFilter: $('#StatusFilterId').val(),
                        cityNameFilter: $('#CityNameFilterId').val(),
                        cityName2Filter: $('#CityName2FilterId').val(),
                        jetJetTypeFilter: $('#jetJetTypeFilterId').val()
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

		$('#ShowAdvancedFiltersSpan').click(function () {
            $('#ShowAdvancedFiltersSpan').hide();
            $('#HideAdvancedFiltersSpan').show();
            $('#AdvacedAuditFiltersArea').slideDown();
        });

        $('#HideAdvancedFiltersSpan').click(function () {
            $('#HideAdvancedFiltersSpan').hide();
            $('#ShowAdvancedFiltersSpan').show();
            $('#AdvacedAuditFiltersArea').slideUp();
        });

        $('#CreateNewFlightButton').click(function () {
            _createOrEditModal.open();
        });


        abp.event.on('app.createOrEditFlightModalSaved', function () {
            getFlights();
        });

		$('#GetFlightsButton').click(function (e) {
            e.preventDefault();
            getFlights();
        });

		$(document).keypress(function(e) {
		  if(e.which === 13) {
			getFlights();
		  }
		});
    });
})();