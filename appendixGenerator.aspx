<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="appendixGenerator.aspx.cs" Inherits="appendixGenerator" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h2 style="text-align: center; color: #404C59">Community Planning Data and Map Book</h2>
    <p class="centerText">
        <span style="font-size: 10pt; color: #000000;">
            <em>
                <strong>Analysis of Data and Information to Support Georgia's Local Planning Requirements </strong>
            </em>
        </span>
    </p>
    <asp:HiddenField id="comm" runat="server" />
    <asp:HiddenField id="juris" runat="server" />
    <strong>
        <span style="font-size: 10pt;">
            <input id="cbAllDataItems" type="checkbox" name="cbAllDataItems" onclick="javascript:setChecked('cbAllDataItems','cbPop,cbEcon,cbHous,cbMap,cbPopAll,cbEconAllItems,cbHousAllItems,cbAllMapItems');setParams('cbAllDataItems')" />
            <asp:Label runat="server" Text="Check if you want to report all Data Items" />
        </span>
    </strong>
    <table style="font-weight: bold">
        <tr>
            <td style="width: 243px; font-weight: bold; color: white; background-color: #F69501; text-align: center;">
                <input id="cbPopAll" type="checkbox" name="cbPopAll" onclick="javascript:setChecked('cbPopAll',cbPop);setParams('cbPopAll')" />
                <asp:Label runat="server" Text="All Population Demographics" />
            </td>
            <td style="width: 243px; font-weight: bold; color: white; background-color: #F69501; text-align: center;">
                <input id="cbEconAllItems" type="checkbox" name="cbEconAllItems" onclick="javascript:setChecked('cbEconAllItems',cbEcon);setParams('cbEconAllItems')" />
                <asp:Label runat="server" Text="All Economic Demographics" />
            </td>
            <td style="width: 243px; font-weight: bold; color: white; background-color: #F69501; text-align: center;">
                <input id="cbHousAllItems" type="checkbox" name="cbHousAllItems" onclick="javascript:setChecked('cbHousAllItems',cbHous);setParams('cbHousAllItems')" />
                <asp:Label runat="server" Text="All Housing Demographics" />
            </td>
        </tr>
        <tr>
            <td style="width: 241px; height: 84px; font-weight: normal; font-size: 10pt; background-color: #D3DCE5;" valign="top">
                <input id="cbPopTotal" type="checkbox" name="cbPop" onclick="javascript:setParams('cbPopTotal')" />
                <asp:Label runat="server" Text="Total Population" /><br />
                <input id="cbPopAge" type="checkbox" name="cbPop" onclick="javascript:setParams('cbPopAge')" />
                <asp:Label runat="server" Text="Age Distribution" /><br />
                <input id="cbPopRace" type="checkbox" name="cbPop" onclick="javascript:setParams('cbPopRace')" />
                <asp:Label runat="server" Text="Racial and Ethnicity" /><br />
                <input id="cbPopHouseIncome" type="checkbox" name="cbPop" onclick="javascript:setParams('cbPopHouseIncome')" />
                <asp:Label runat="server" Text="Income" /><br />
            </td>
            <td style="width: 241px; height: 84px; font-weight: normal; font-size: 10pt; background-color: #D3DCE5;" valign="top">
                <input id="cbEconEmployment" type="checkbox" name="cbEcon" onclick="javascript:setParams('cbEconEmployment')" />
                <asp:Label runat="server" Text="Economic Base" /><br />
                <input id="cbEconLFParticipation" type="checkbox" name="cbEcon" onclick="javascript:setParams('cbEconLFParticipation')" />
                <asp:Label runat="server" Text="Labor Force" /><br />
                <input id="cbEconEducation" type="checkbox" name="cbEcon" onclick="javascript:setParams('cbEconEducation')" />
                <asp:Label runat="server" Text="Economic Resources" /><br />
                <input id="cbEconResources" type="checkbox" name="cbEcon" onclick="javascript:setParams('cbEconResources')" />
                <asp:Label runat="server" Text="Economic Trends" />
            </td>
            <td style="width: 241px; height: 84px; font-weight: normal; font-size: 10pt; background-color: #D3DCE5;" valign="top">
                <input id="cbHousTypes" type="checkbox" name="cbHous" onclick="javascript:setParams('cbHousTypes')" />
                <asp:Label runat="server" Text="Housing Types and Mix" /><br />
                <input id="cbHousOccupancy" type="checkbox" name="cbHous" onclick="javascript:setParams('cbHousOccupancy')" />
                <asp:Label runat="server" Text="Condition and Occupancy" /><br />
                <input id="cbHousCost" type="checkbox" name="cbHous" onclick="javascript:setParams('cbHousCost')" />
                <asp:Label ID="Label1" runat="server" Text="Cost of Housing" /><br />
                <input id="cbHousBurdened" type="checkbox" name="cbHous" onclick="javascript:setParams('cbHousBurdened')" />
                <asp:Label runat="server" Text="Cost Burdened Households" /><br />
            </td>
        </tr>
    </table>
    <br />
    <span style="font-size: 10pt;">
        <strong>&nbsp;
            <input id="cbAllMapItems" type="checkbox" name="cbAllMapItems" onclick="javascript:setChecked('cbAllMapItems',cbMap);setParams('cbAllMapItems')" />
            <asp:Label runat="server" Text = "Check if you want to report all Map Items" />
        </strong>
        <br />
    </span>    
    <table style="font-weight: bold">
        <tr>
            <td style="width: 243px; font-weight: bold; color: white; background-color: #F69501; text-align: center;">
                Transportation
            </td>
            <td style="width: 243px; font-weight: bold; color: white; background-color: #F69501; text-align: center;">
                Natural Resources
            </td>
            <td style="width: 243px; font-weight: bold; color: white; background-color: #F69501; text-align: center;">
                Community Facilities
            </td>
        </tr>
        <tr>
            <td style="width: 243px; font-weight: normal; font-size: 10pt; background-color: #D3DCE5;" valign="top">
                <input id="cbMapRef" type="checkbox" name="cbMap" onclick="javascript:setParams('cbMapRef')" />
                <asp:Label runat="server" Text="Reference Map" />
                <br />&nbsp;
            </td>
            <td style="width: 243px; font-weight: normal; font-size: 10pt; background-color: #D3DCE5;" valign="top">
                <input id="cbMapFlood" type="checkbox" name="cbMap" onclick="javascript:setParams('cbMapFlood')" />
                <asp:Label runat="server" Text="National Wetlands Inventory" />
                <br />
            </td>
            <td style="width: 243px; font-weight: normal; font-size: 10pt; background-color: #D3DCE5;" valign="top">
                <input id="cbMapELU" type="checkbox" name="cbMap" onclick="javascript:setParams('cbMapELU')" />
                <asp:Label runat="server" Text="Community Facilities" /><br />
            </td>
        </tr>
    </table>
    <br />
    <br />
    <div style="text-align: left">
        <table>
            <tr>
                <td style="width: 100px">
                    <asp:Button runat="server" value="View PDF" Text="View PDF" id="btnCountyPDF" OnClientClick="generatePage('PDF')" />
                </td>
                <td style="width: 100px">
                    <asp:Button runat="server" value="View Html" Text="View Html" 
                        id="btnCountyHtml" OnClientClick="generatePage('HTML4.0')" />
                </td>
            </tr>
        </table>
    </div>
    <script language="javascript" type="text/javascript">
// <!CDATA[

        function setChecked(cb, group) {
            if (cb != 'cbAllDataItems') {
                if (document.getElementById(cb).checked) {
                    for (i = 0; i < group.length; i++) {
                        group[i].checked = true;
                        group[i].disabled = true;
                    }
                } else {
                    for (i = 0; i < group.length; i++) {
                        group[i].checked = false;
                        group[i].disabled = false;
                    }
                }
            } else {
                var grpArr = group.split(',');
                for (x = 0; x < grpArr.length; x++) {
                    if (document.getElementById(cb).checked) {
                        group = document.getElementsByName(grpArr[x]);
                        for (i = 0; i < group.length; i++) {
                            group[i].checked = true;
                            group[i].disabled = true;
                        }
                    } else {
                    group = document.getElementsByName(grpArr[x]);
                        for (i = 0; i < group.length; i++) {
                            group[i].checked = false;
                            group[i].disabled = false;
                        }
                    }
                }
            }
        }
        //parameters for the query string
        var PopTotal = true, PopRace = true, PopHispanic = false, PopHouseholds = false,
            PopHouseIncome = true, PopSeasonal = false, MapRef = true, MapFlood = true, MapELU = true,
            EconEmp = true, EconIncome = false, EconLFWork = false, EconLFPar = true, EconEd = true,
            EconPerCap = false, EconRes = true, HousTypes = true, HousAge = false, HousCondition = false, 
            HousOccupancy = true, HousCost = true, HousBurdened = true, HousOver = false, PopAge = true;

        function setParams(cb) {
            var cb;
            //Population Params
            if (((cb == 'cbPopTotal') || (cb == 'cbAllDataItems') || (cb == 'cbPopAll')) && (document.getElementById(cb).checked)) {
                PopTotal = false;
            }
            if (((cb == 'cbPopAge') || (cb == 'cbAllDataItems') || (cb == 'cbPopAll')) && (document.getElementById(cb).checked)) {
                PopAge = false;
            }
            if (((cb == 'cbPopRace') || (cb == 'cbAllDataItems') || (cb == 'cbPopAll')) && (document.getElementById(cb).checked)) {
                PopRace = false;
            }
            if (((cb == 'cbPopHouseIncome') || (cb == 'cbAllDataItems') || (cb == 'cbPopAll')) && (document.getElementById(cb).checked)) {
                PopHouseIncome = false;
            }
            //Econ Params
            if (((cb == 'cbEconEmployment') || (cb == 'cbAllDataItems') || (cb == 'cbEconAllItems')) && (document.getElementById(cb).checked)) {
                EconEmp = false;
            }
            if (((cb == 'cbEconLFParticipation') || (cb == 'cbAllDataItems') || (cb == 'cbEconAllItems')) && (document.getElementById(cb).checked)) {
                EconLFPar = false;
            }
            if (((cb == 'cbEconEducation') || (cb == 'cbAllDataItems') || (cb == 'cbEconAllItems')) && (document.getElementById(cb).checked)) {
                EconEd = false;
            }
            if (((cb == 'cbEconResources') || (cb == 'cbAllDataItems') || (cb == 'cbEconAllItems')) && (document.getElementById(cb).checked)) {
                EconRes = false;
            }
            //Housing Params
            if (((cb == 'cbHousTypes') || (cb == 'cbAllDataItems') || (cb == 'cbHousAllItems')) && (document.getElementById(cb).checked)) {
                HousTypes = false;
            }
            if (((cb == 'cbHousOccupancy') || (cb == 'cbAllDataItems') || (cb == 'cbHousAllItems')) && (document.getElementById(cb).checked)) {
                HousOccupancy = false;
            }
            if (((cb == 'cbHousCost') || (cb == 'cbAllDataItems') || (cb == 'cbHousAllItems')) && (document.getElementById(cb).checked)) {
                HousCost = false;
            }
            if (((cb == 'cbHousBurdened') || (cb == 'cbAllDataItems') || (cb == 'cbHousAllItems')) && (document.getElementById(cb).checked)) {
                HousBurdened = false;
            }
            //Map Params
            if (((cb == 'cbMapRef') || (cb == 'cbAllDataItems') || (cb == 'cbAllMapItems')) && (document.getElementById(cb).checked)) {
                MapRef = false;
            }
            if (((cb == 'cbMapFlood') || (cb == 'cbAllDataItems') || (cb == 'cbAllMapItems')) && (document.getElementById(cb).checked)) {
                MapFlood = false;
            }
            if (((cb == 'cbMapELU') || (cb == 'cbAllDataItems') || (cb == 'cbAllMapItems')) && (document.getElementById(cb).checked)) {
                MapELU = false;
            }
        }
        function generatePage(format) {
            var comm = "<%= comm.Value %>";
            var juris = "<%= juris.Value %>";
            var urlBase = "http://dungeness.dca.ga.gov/ReportServer/Pages/ReportViewer.aspx?/AppendixReports/" + juris + "Demographics&rs:Format=" + format + "&rs:Command=Render&Jurisdiction=";
            var url = urlBase + comm + "&Hide" + juris + "PopTotal=" + PopTotal + "&Hide" + juris + "PopRace=" + PopRace + "&Hide" + juris + "PopHispanic=" + PopHispanic + "&Hide" + juris + "PopHouseholds=" + PopHouseholds + "&Hide" + juris + "PopHouseIncome=" + PopHouseIncome + "&Hide" + juris + "PopSeasonal=" + PopSeasonal + "&Hide" + juris + "MapReference=" + MapRef + "&Hide" + juris + "MapFlood=" + MapFlood + "&Hide" + juris + "MapELU=" + MapELU + "&Hide" + juris + "EconEmployment=" + EconEmp + "&Hide" + juris + "EconIncomeType=" + EconIncome + "&Hide" + juris + "EconLFWork=" + EconLFWork + "&Hide" + juris + "EconLFParticipation=" + EconLFPar + "&Hide" + juris + "EconEducation=" + EconEd + "&Hide" + juris + "EconPerCapita=" + EconPerCap + "&Hide" + juris + "EconResources=" + EconRes + "&Hide" + juris + "HousTypes=" + HousTypes + "&Hide" + juris + "HousAge=" + HousAge + "&Hide" + juris + "HousCondition=" + HousCondition + "&Hide" + juris + "HousOccupancy=" + HousOccupancy + "&Hide" + juris + "HousCost=" + HousCost + "&Hide" + juris + "HousBurdened=" + HousBurdened + "&Hide" + juris + "HousOvercrowding=" + HousOver + "&Hide" + juris + "PopAge=" + PopAge + "&rc:Parameters=false";
            window.open(url); 
        }

// ]]>
    </script>
</asp:Content>

