<%@ Page Language="C#" MasterPageFile="~/PlanningDataMaster.master" AutoEventWireup="true"
    CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <h2 class="centerText">
        Local Planning Assistance</h2>
    <p style="height: 60px">
        The Office of Planning provides guidance, 
        assistance and a variety of resources to help local governments comply with 
        state requirements for
        <a href="http://www.dca.state.ga.us/development/PlanningQualityGrowth/programs/communityplans.asp">
        Local Comprehensive Plans</a>, working out county-wide strategies for delivery 
        of public services
        <a href="http://www.dca.state.ga.us/development/PlanningQualityGrowth/programs/servicedelivery.asp">
        (Service Delivery Strategies)</a> and establishing a local
        <a href="http://www.dca.state.ga.us/development/PlanningQualityGrowth/programs/impactfees.asp">
        Impact Fee</a> system.</p>
    
        <table width="100%" border="0">
            <tr>
                <td style="width: 260px">
                    <h3>Preparing Your Local Plan</h3>
                    <a href="http://www.dca.ga.gov/development/PlanningQualityGrowth/PAGES/Local/planning.asp">Local Planning 
                    Standards</a><br />
                    <a href="http://www.dca.ga.gov/development/PlanningQualityGrowth/programs/spr.asp">
                    State Planning Recommendations</a><br />
                    <a href="http://www.dca.ga.gov/development/PlanningQualityGrowth/programs/ppt.asp">
                    Plan Preparation Tools</a><br />
                    <a href="http://www.georgiaplanning.com/dataviews/census2/" target="_blank">Data 
                    Resources</a><br />
                    <a href="http://www.dca.ga.gov/development/PlanningQualityGrowth/programs/goplexamples.asp" 
                        target="_blank">Good Plan Examples</a></p>
                </td>
                <td><p /><br />
                    <div style="width: 475px; border-color: Silver; border-style: solid; border-width:thin; border-radius: 17px;">
                        <p style="text-align:center">
                           Please visit <span style="font-style: italic; font-weight: bold;">Your Local Government Planning Resources</span> web page by selecting
                                <br /><br />
                            County :
                            <asp:DropDownList AutoPostBack="true" runat="server" AppendDataBoundItems="true"
                                ID="countyName" DataTextField="Gov_Name" DataValueField="FIPS">
                                <asp:ListItem Text="Select a County" Value="0" />
                            </asp:DropDownList>
                            <br />
                            OR
                            <br />
                            City :
                            <asp:DropDownList AutoPostBack="true" runat="server" AppendDataBoundItems="true"
                                ID="cityName" DataTextField="Gov_Name" DataValueField="FIPS">
                                <asp:ListItem Text="Select a City" Value="0" />
                            </asp:DropDownList>
                        </p>
                    </div>
                </td>
            </tr>
        </table>
    <h3>
        View Community Plans</h3>    
        <a href="http://www.dca.ga.gov/development/PlanningQualityGrowth/programs/currentplans.asp">Community Plans</a>
    <h3>
        Development Impact Fees &amp; Capital Improvements Planning
    </h3> 
        <a href="http://www.dca.ga.gov/development/PlanningQualityGrowth/programs/impactfees.asp">
        Impact Fees</a>
        <h3>Service Delivery Strategy</h3>
        <a href="http://www.dca.ga.gov/development/PlanningQualityGrowth/programs/servicedelivery.asp">
        Service Delivery Strategy</a>
    <h3>
        Other Publications and Resources</h3>
        <a href="http://www.dca.ga.gov/development/PlanningQualityGrowth/programs/downloads/guidebooks/WhyPlan.pdf" 
            target="_blank">Why Do We Plan?</a><!-- #BeginLibraryItem "http://www.dca.ga.gov/Library/pdf.lbi" --> 
        (PDF) <!-- #EndLibraryItem -->
    <br />
        <a href="http://www.dca.ga.gov/development/PlanningQualityGrowth/programs/downloads/PlanPreparerGuidebook.pdf">
        Selecting a Plan Preparer</a><!-- #BeginLibraryItem "http://www.dca.ga.gov/Library/pdf.lbi" --> 
        (PDF) <!-- #EndLibraryItem -->
    <br />
        <a href="http://www.dca.ga.gov/development/PlanningQualityGrowth/programs/downloads/guidebooks/PlanningCommunityInvolvement.pdf" 
            target="_blank">Planning for Community Involvement</a><!-- #BeginLibraryItem "http://www.dca.ga.gov/Library/pdf.lbi" --> 
        (PDF) <!-- #EndLibraryItem -->

    <br />
        <a href="http://www.dca.ga.gov/development/PlanningQualityGrowth/programs/selling.asp">
        Selling Planning and Quality Growth</a><br />
        <a href="http://www.dca.ga.gov/development/PlanningQualityGrowth/programs/servicedelivery.asp">
        </a>
        <a href="http://www.dca.ga.gov/development/PlanningQualityGrowth/programs/presskit.asp">
        Planning Press Kit </a>
        <br />
        <a href="http://www.dca.ga.gov/development/PlanningQualityGrowth/programs/smallareaplanning.asp">
        Planning for Character Areas</a><br />
        <a href="http://www.dca.ga.gov/development/PlanningQualityGrowth/programs/downloads/QLG_Programs.pdf" 
            target="_blank">Programs linked to Qualified Local Government Status</a>
    <h3>
        Contact Information<a name="ContactInformation"></a></h3>
    <!-- #BeginLibraryItem "http://www.dca.ga.gov/Library/Contact%20Address.lbi" -->
    <strong>Georgia Department of Community Affairs </strong>
        <br />
        60 Executive Park South, N.E.
        <br />
        Atlanta, Georgia 30329-2231<!-- #EndLibraryItem --><p>
        For more information about planning and environmental management, please contact 
        the <a href="http://www.dca.ga.gov/DCAEmail/contactdca.aspx?totype=28" 
            target="_blank">Office of Planning</a> at 
        404-679-5279.</p>
    <!-- InstanceEndEditable -->
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;<br />
        <br />
        
    </p>
    
    <br />
</asp:Content>
