(function () {
    $(function () {

        var _$citiesTable = $('#CitiesTable');
        var _citiesService = abp.services.app.cities;
		
        var _permissions = {
            create: abp.auth.hasPermission('Pages.Cities.Create'),
            edit: abp.auth.hasPermission('Pages.Cities.Edit'),
            'delete': abp.auth.hasPermission('Pages.Cities.Delete')
        };

        var _createOrEditModal = new app.ModalManager({
            viewUrl: abp.appPath + 'Cities/CreateOrEditModal',
            scriptUrl: abp.appPath + 'view-resources/Views/Cities/_CreateOrEditModal.js',
            modalClass: 'CreateOrEditCityModal'
        });

		 var _viewCityModal = new app.ModalManager({
            viewUrl: abp.appPath + 'Cities/ViewcityModal',
            modalClass: 'ViewCityModal'
        });

        var dataTable = _$citiesTable.DataTable({
            paging: true,
            serverSide: true,
            processing: true,
            listAction: {
                ajaxFunction: _citiesService.getAll,
                inputFilter: function () {
                    return {
					filter: $('#CitiesTableFilter').val()
                    };
                }
            },
            columnDefs: [
                {
                    width: 120,
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
                                    _viewCityModal.open({ id: data.record.city.id });
                                }
                        },
						{
                            text: app.localize('Edit'),
                            visible: function () {
                                return _permissions.edit;
                            },
                            action: function (data) {
                                _createOrEditModal.open({ id: data.record.city.id });
                            }
                        }, 
						{
                            text: app.localize('Delete'),
                            visible: function () {
                                return _permissions.delete;
                            },
                            action: function (data) {
                                deleteCity(data.record.city);
                            }
                        }]
                    }
                },
					{
						targets: 1,
						 data: "city.code",
						 name: "code"   
					},
					{
						targets: 2,
						 data: "city.name",
						 name: "name"   
					},
					{
						targets: 3,
						 data: "city.displayName",
						 name: "displayName"   
					},
					{
						targets: 4,
						 data: "city.country",
						 name: "country"   
					}
            ]
        });

        function getCities() {
            dataTable.ajax.reload();
        }

        function deleteCity(city) {
            abp.message.confirm(
                '',
                app.localize('AreYouSure'),
                function (isConfirmed) {
                    if (isConfirmed) {
                        _citiesService.delete({
                            id: city.id
                        }).done(function () {
                            getCities(true);
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

        $('#CreateNewCityButton').click(function () {
            _createOrEditModal.open();
        });

		

        abp.event.on('app.createOrEditCityModalSaved', function () {
            getCities();
        });

		$('#GetCitiesButton').click(function (e) {
            e.preventDefault();
            getCities();
        });

		$(document).keypress(function(e) {
		  if(e.which === 13) {
			getCities();
		  }
		});
    });
})();