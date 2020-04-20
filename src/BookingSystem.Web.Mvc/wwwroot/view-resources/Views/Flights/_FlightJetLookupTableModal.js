(function ($) {
    app.modals.JetLookupTableModal = function () {

        var _modalManager;

        var _flightsService = abp.services.app.flights;
        var _$jetTable = $('#JetTable');

        this.init = function (modalManager) {
            _modalManager = modalManager;
        };


        var dataTable = _$jetTable.DataTable({
            paging: true,
            serverSide: true,
            processing: true,
            listAction: {
                ajaxFunction: _flightsService.getAllJetForLookupTable,
                inputFilter: function () {
                    return {
                        filter: $('#JetTableFilter').val()
                    };
                }
            },
            columnDefs: [
                {
                    targets: 0,
                    data: null,
                    orderable: false,
                    autoWidth: false,
                    defaultContent: "<div class=\"text-center\"><input id='selectbtn' class='btn btn-success' type='button' width='25px' value='" + app.localize('Select') + "' /></div>"
                },
                {
                    autoWidth: false,
                    orderable: false,
                    targets: 1,
                    data: "displayName"
                }
            ]
        });

        $('#JetTable tbody').on('click', '[id*=selectbtn]', function () {
            var data = dataTable.row($(this).parents('tr')).data();
            _modalManager.setResult(data);
            _modalManager.close();
        });

        function getJet() {
            dataTable.ajax.reload();
        }

        $('#GetJetButton').click(function (e) {
            e.preventDefault();
            getJet();
        });

        $('#SelectButton').click(function (e) {
            e.preventDefault();
        });

        $(document).keypress(function (e) {
            if (e.which === 13) {
                getJet();
            }
        });

    };
})(jQuery);

