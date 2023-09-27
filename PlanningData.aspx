<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeFile="PlanningData.aspx.cs" Inherits="PlanningData" Title="" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div id="data">
        <div>
            <h2>
                Planning Data for
                <asp:Label ID="CommName" runat="server" /></h2>
        </div>
        <img src="images/yellow_ball.gif" alt="" /><asp:HyperLink runat="server" ID="HyperLink1">Upcoming Planning Due Dates</asp:HyperLink>
        <br />
        <br />
        <asp:HyperLink Target="_blank" runat="server" ID="HyperLink2">Jointly Planned Communities</asp:HyperLink>
        <br />
        <br />
        <asp:HyperLink Target="_blank" runat="server" ID="HyperLink3">Required Signatures for this Community’s Service Delivery Strategy (SDS)</asp:HyperLink>
        <br />
        <br />
        <asp:HyperLink Target="_blank" runat="server" NavigateUrl="#timeline" ID="HyperLink4">Planning Timeline</asp:HyperLink>
        <br />
        <br />
        <img src="images/red_ball.gif" alt="" /><asp:HyperLink runat="server" NavigateUrl="http://www.georgiaplanning.com/planners/planreview/"
            ID="HyperLink5">Qualified Local Government (QLG) Status</asp:HyperLink>
        <br />
        <asp:HyperLink Target="_blank" CssClass="marginLeftLarge" runat="server" NavigateUrl="http://dca.ga.gov/development/PlanningQualityGrowth/programs/downloads/QLG_Programs.pdf"
            ID="HyperLink7">Programs Linked to QLG Status (PDF)</asp:HyperLink>
        <br />
        <br />
        <asp:HyperLink Target="_blank" runat="server" ID="HyperLink6">Community’s Planning Documents</asp:HyperLink>
        <br />
        <div class="marginLeftLarge">
            <asp:HyperLink Target="_blank" runat="server" NavigateUrl="http://dca.ga.gov/development/PlanningQualityGrowth/programs/communityplans.asp"
                ID="HyperLink8">Comprehensive Plan and Maps</asp:HyperLink><br />
            Short Term Work Program (STWP)<br />
            SDS and Maps<br />
            Capital Improvement Element/Program (CIE/CIP)<br />
            Developments of Regional Impact (DRI)<br />
            Regionally Important Resources (RIR)<br />
            Regional Plan (i.e., Coastal Plan, Rural GA Plan)<br />
            Regional Greenway Plan<br />
            Solid Waste Management Plan (SWMP)<br />
            <asp:HyperLink Target="_blank" runat="server" NavigateUrl="http://www.georgiaplanning.com/annex.htm"
                ID="HyperLink27">Annexation Reports</asp:HyperLink><br />
            
            <br />
        </div>
    </div>
    
</asp:Content>
