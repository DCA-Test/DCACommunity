<%@ Page Language="C#" MasterPageFile="~/PlanningDataMaster.master" AutoEventWireup="true"
    CodeFile="CommunitySelection.aspx.cs" Inherits="CommunitySelection" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01//EN" "http://www.w3.org/TR/html4/strict.dtd">
    <html>
    <head id="Head1">
        <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
        <title>County Snapshots</title>
        <link rel="stylesheet" type="text/css" href="http://serverapi.arcgisonline.com/jsapi/arcgis/1.3/js/dojo/dijit/themes/tundra/tundra.css" />

        <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.2.6/jquery.min.js"> </script>

    </head>
    <body class="tundra">

        <h3>
            Select a County or City
        </h3>
        <p>
        County :
        <asp:DropDownList AutoPostBack="true" runat="server" AppendDataBoundItems="true"
            ID="countyName" DataTextField="Gov_Name" DataValueField="FIPS">
            <asp:ListItem Text="Select a County" Value="0" />
        </asp:DropDownList>
        <br />
        <br />
        City :
        <asp:DropDownList AutoPostBack="true" runat="server" AppendDataBoundItems="true"
            ID="cityName" DataTextField="Gov_Name" DataValueField="FIPS">
            <asp:ListItem Text="Select a City" Value="0" />
        </asp:DropDownList>
    </p>
    </body>
    </html>
</asp:Content>
