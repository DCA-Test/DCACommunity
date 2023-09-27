<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="AssistanceResources.aspx.cs" Inherits="AssisstanceResources" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="resources">
        <div>
            <h2>
                Assistance Resources for <asp:Label ID="CommName" runat="server" /></h2>
        </div>
        <br />
        <div style="width: 100%">
            Area Planner Contact Info
            <br />
            <br />
            Technical Assistance Contact Info<br />
            <br />
            Regional Representative Contact Info<br />
            <br />
            <asp:HyperLink Target="_blank" runat="server" NavigateUrl="http://dca.ga.gov/main/teamga/index.asp"
                ID="HyperLink28">Team Georgia Link</asp:HyperLink><br />
            <br />
            Regional Commission Contact Info<br />
            <br />
            <asp:HyperLink Target="_blank" runat="server" NavigateUrl="http://dca.ga.gov/development/PlanningQualityGrowth/programs/opqg.asp"
                ID="HyperLink29">Planning Workshops and Training Opportunities</asp:HyperLink><br />
            <br />
            <asp:HyperLink Target="_blank" runat="server" NavigateUrl="http://dca.ga.gov/toolkit/gaexamples.asp"
                ID="HyperLink30">Georgia&#39;s Best Examples</asp:HyperLink><br />
            <br />
            <asp:HyperLink Target="_blank" runat="server" NavigateUrl="http://dca.ga.gov/development/PlanningQualityGrowth/programs/modelcode.asp"
                ID="HyperLink31">Alternatives for Conventional Zoning</asp:HyperLink><br />
            <br />
        </div>
    </div>
</asp:Content>