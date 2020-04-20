(function () {
    $(function () {

        var _$jetsTable = $('#JetsTable');
        var _jetsService = abp.services.app.jets;

        var _permissions = {
            create: abp.auth.hasPermission('Pages.Jets.Create'),
            edit: abp.auth.hasPermission('Pages.Jets.Edit'),
            'delete': abp.auth.hasPermission('Pages.Jets.Delete')
        };

        var _createOrEditModal = new app.ModalManager({
            viewUrl: abp.appPath + 'Jets/CreateOrEditModal',
            scriptUrl: abp.appPath + 'view-resources/Views/Jets/_CreateOrEditModal.js',
            modalClass: 'CreateOrEditJetModal'
        });

		 var _viewJetModal = new app.ModalManager({
            viewUrl: abp.appPath + 'Jets/ViewjetModal',
            modalClass: 'ViewJetModal'
        });

        var dataTable = _$jetsTable.DataTable({
            paging: true,
            serverSide: true,
            processing: true,
            listAction: {
                ajaxFunction: _jetsService.getAll,
                inputFilter: function () {
                    return {
					filter: $('#JetsTableFilter').val(),
					isActiveFilter: $('#IsActiveFilterId').val()
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
                                    _viewJetModal.open({ id: data.record.jet.id });
                                }
                        },
						{
                            text: app.localize('Edit'),
                            visible: function () {
                                return _permissions.edit;
                            },
                            action: function (data) {
                                _createOrEditModal.open({ id: data.record.jet.id });
                            }
                        }, 
						{
                            text: app.localize('Delete'),
                            visible: function () {
                                return _permissions.delete;
                            },
                            action: function (data) {
                                deleteJet(data.record.jet);
                            }
                        }]
                    }
                },
					{
						targets: 1,
						 data: "jet.jetType",
						 name: "jetType"   
					},
					{
						targets: 2,
						 data: "jet.totalCapacity",
						 name: "totalCapacity"   
					},
					{
						targets: 3,
						 data: "jet.isActive",
						 name: "isActive"  ,
						render: function (isActive) {
							if (isActive) {
								return '<div class="text-center"><i class="fa fa-check kt--font-success" title="True"></i></div>';
							}
							return '<div class="text-center"><i class="fa fa-times-circle" title="False"></i></div>';
					}
			 
					}
            ]
        });

        function getJets() {
            dataTable.ajax.reload();
        }

        function deleteJet(jet) {
            abp.message.confirm(
                '',
                app.localize('AreYouSure'),
                function (isConfirmed) {
                    if (isConfirmed) {
                        _jetsService.delete({
                            id: jet.id
                        }).done(function () {
                            getJets(true);
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

        $('#CreateNewJetButton').click(function () {
            _createOrEditModal.open();
        });

		

        abp.event.on('app.createOrEditJetModalSaved', function () {
            getJets();
        });

		$('#GetJetsButton').click(function (e) {
            e.preventDefault();
            getJets();
        });

		$(document).keypress(function(e) {
		  if(e.which === 13) {
			getJets();
		  }
		});
    });
})();