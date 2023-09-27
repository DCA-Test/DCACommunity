<%@ Page Language="C#" MasterPageFile="~/PlanningDataMaster.master" AutoEventWireup="true"
    CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <h2 class="centerText">
        Local Planning Assistance</h2>
    <p style="height: 60px">
        The Office of Planning provides guidance, 
        assistance and a variety of resources to help local governments comply with 
        state requirements for
        <a href="https://www.dca.ga.gov/local-government-assistance/planning/local-planning/local-comprehensive-planning">
        Local Comprehensive Plans</a>, working out county-wide strategies for delivery 
        of public services
        <a href="https://www.dca.ga.gov/local-government-assistance/planning/intergovernmental-coordination/service-delivery-strategies-sds">
        (Service Delivery Strategies)</a> and establishing a local
        <a href="https://www.dca.ga.gov/local-government-assistance/planning/local-planning/development-impact-fees-capital-improvements">
        Impact Fee</a> system.</p>
    
        <table width="100%" border="0">
            <tr>
                <td style="width: 260px">
                    <h3>Preparing Your Local Plan</h3>
                    <a href="https://www.dca.ga.gov/local-government-assistance/planning/local-planning/local-comprehensive-planning">Comprehensive Planning Information</a><br />
                    <a href="http://apps.dca.ga.gov/development/PlanningQualityGrowth/DOCUMENTS/Laws.Rules.Guidelines.Etc/DCARules.LPRs.pdf">Local Planning 
                    Standards</a> (PDF) <br />
                    <a href="https://www.dca.ga.gov/node/5903">
                    State Planning Recommendations</a><br />
                    <a href="http://www.georgiaplanning.com/dataforplanning.asp" target="_blank">Data Resources</a><br />
                    <a href="https://www.dca.ga.gov/node/1962/documents/2088">View Community Plans</a><br />
                </p>
                </td>
                <td><p /><br />
                    <div style="width: 475px; border-color: Silver; border-style: solid; border-width:thin; border-radius: 17px;">
                        <p style="text-align:center">
                            Select your community, below, to view applicable community planning due-dates.
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
        </h3>    
    <h3>
        CIEs &amp; Development Impact Fees
    </h3> 
        <a href="https://www.dca.ga.gov/local-government-assistance/planning/local-planning/development-impact-fees-capital-improvements">
        Impact Fee Information</a><br />
        <a href="http://apps.dca.ga.gov/development/PlanningQualityGrowth/DOCUMENTS/Laws.Rules.Guidelines.Etc/DCARules.ImpactFees.PDF">
            Impact Fee Standards</a> (PDF)
        <h3>Service Delivery Strategy</h3>
        <a href="https://www.dca.ga.gov/local-government-assistance/planning/intergovernmental-coordination/service-delivery-strategies-sds">
        Service Delivery Strategy (SDS) Information</a><br />
        <a href="http://apps.dca.ga.gov/development/PlanningQualityGrowth/DOCUMENTS/Laws.Rules.Guidelines.Etc/ServiceDeliveryAct.pdf">
        Service Delivery Act</a> (PDF)<br />
        <a href="https://www.dca.ga.gov/node/4806">
        SDS Forms</a><br />
        <a href="https://www.dca.ga.gov/node/2111/documents/2088">
        View SDSs</a><br />
            <h3>
        Other Publications and Resources</h3>
        <a href="https://www.dca.ga.gov/sites/default/files/whyplan.pdf" 
            target="_blank">Why Do We Plan?</a><!-- #BeginLibraryItem "http://www.dca.ga.gov/Library/pdf.lbi" --> 
        (PDF) <!-- #EndLibraryItem -->
    <br />
        <a href="https://www.dca.ga.gov/sites/default/files/planpreparerguidebook.pdf">
        Selecting a Plan Preparer</a><!-- #BeginLibraryItem "http://www.dca.ga.gov/Library/pdf.lbi" --> 
        (PDF) <!-- #EndLibraryItem -->
    <br />
        <a href="https://www.dca.ga.gov/sites/default/files/planningcommunityinvolvement.pdf" 
            target="_blank">Planning for Community Involvement</a><!-- #BeginLibraryItem "http://www.dca.ga.gov/Library/pdf.lbi" --> 
        (PDF)<br /> <!-- #EndLibraryItem -->
        <a href="https://www.dca.ga.gov/sites/default/files/characterareaguide.pdf">
        Planning for Character Areas</a> (PDF)<br />
        <a href="https://www.dca.ga.gov/sites/default/files/programs_linked_to_qlg.03092018.pdf" 
            target="_blank">Programs linked to Qualified Local Government Status</a> (PDF)
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
