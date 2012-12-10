<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage" %>
<script type="text/javascript">

    google.load("visualization", "1", { packages: ["corechart"] });
    google.setOnLoadCallback(drawSalesChart);

    function drawSalesChart() {

        $.post('<%= Url.Content("~/dashboard/getPieChartData") %>', {},
            function (data) {
                var tdata = new google.visualization.DataTable();

                tdata.addColumn('string', 'Dispositivo');
                tdata.addColumn('number', 'Cantidad');

                for (var i = 0; i < data.length; i++) {
                    tdata.addRow([data[i].Name, data[i].Value]);
                    i = i + 2;
                }

                var options = {
                    title: "Top 5 de los dispositivos que ingresan a la aplicacion"
                };

                var chart = new google.visualization.PieChart(document.getElementById('chartSales'));
                chart.draw(tdata, options);
            });

    }
</script>
<div class="dashboardItem">
    <div class="dashboardItemHeader">Dispositivos que mas usan la plataforma.</div>
    <div class="dashboardItemBody">
        <div id="chartSales" style="">
            <div class="ajaxLoading"></div>
         </div>
    </div>
</div>