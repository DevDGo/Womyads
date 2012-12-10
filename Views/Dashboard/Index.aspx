<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage" %>
<%{
    ViewBag.Title = "Inicio";
}%>

<html ">
<head runat="server">
    <title></title>
    <script src="<%= Url.Content("~/Scripts/jquery-1.5.1.min.js") %>" type="text/javascript"></script>
    <link href="<%= Url.Content("~/Content/Site.css") %>" rel="stylesheet" type="text/css" />
    <link href="<%= Url.Content("~/Content/dashboard.css") %>" rel="stylesheet" type="text/css" />
    <script type="text/javascript" src="https://www.google.com/jsapi"></script>
</head>
<body>
    <div class="pageHeader">
        <h2>Dashboard Woamyads </h2>
    </div>
    <div class="pageBody">
<div class="dashboard">
    <div class="dashboard3Col">
        <div class="dashboardCol"> 
            <% Html.RenderAction("dashboardItem_Users", "DashBoard"); %>
            <% Html.RenderAction("dashboardItem_Orders", "DashBoard"); %>
        </div>
        <div class="dashboardCol">
            <% Html.RenderAction("dashboardItem_Visitors", "DashBoard"); %>
        </div>
</div>
    </div>
    <footer>
        <center>
      <p>&copy; 2012 DGo. All Rights Reserved</p></center>
    </footer></body>
</html>
