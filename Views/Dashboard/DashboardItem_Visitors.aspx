<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage" %>

<script type="text/javascript">
    google.load("visualization", "1", { packages: ["corechart"] });
    google.setOnLoadCallback(drawVisitorChart);
    function drawVisitorChart() {
        var data = new google.visualization.DataTable();
        data.addColumn('string', 'Año');
        data.addColumn('number', 'Nuebo Visitante');
        data.addColumn('number', 'Visitantes Registrados');
        data.addRows([
          ['2004', 1000, 410],
          ['2008', 1340, 430],
          ['2012', 843, 5430],
          ['2016', 13430, 3430]
        ]);

        var options = {
            title: 'Visitantes Woamyads'
        };

        var chart = new google.visualization.LineChart(document.getElementById('chartVisitors'));
        chart.draw(data, options);
    }
</script>
<div class="dashboardItem">
    <div class="dashboardItemHeader">Visitantes Registrados</div>
    <div class="dashboardItemBody">
         <div id="chartVisitors" style=""></div>
    </div>
</div>