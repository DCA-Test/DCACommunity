<%@ page title="" language="C#" masterpagefile="~/MasterPage.master" autoeventwireup="true"  CodeFile="CommunityHomePage.aspx.cs" Inherits="CommunityHomePage"%>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <script src="http://ajax.aspnetcdn.com/ajax/jquery/jquery-1.9.0.min.js" type="text/javascript"></script>
    <script type="text/javascript">
        function DoCrossSitePost() {
            event.preventDefault();                          
            var searchStr = '<%=Session["com"] %>' + ' ' + '<%=Session["juris"] %>' + ', Georgia';
            var htmlForm = "<form id='myform' method='POST' action='http://factfinder2.census.gov/faces/nav/jsf/pages/community_facts.xhtml'>" +
                 "<input type='text' name='cfsearchtextboxmain' value='" + searchStr.replace(" of", "") + "' />" +
                 "</form>";
            //Submit the form
            $(htmlForm).appendTo("body").submit();
        }
     </script>
    <div style="height: 370px">
        <div style="width: 45%;" class="miniContent">
            <span style="color: #993300"><b>Planning Status</b></span>
            <div style="width: 100%; background-color: #fff;">
                <table style="border: solid Black thin; height: 162px;" width="100%">
                    <tr style="font-size: small">
                        <th style="color: #007171; font-family: Tahoma;">
                            Status
                        </th>
                        <th style="color: #007171; font-family: Tahoma;">
                            Submittal Type
                        </th>
                        <th style="color: #007171; font-family: Tahoma;">
                            Next Date
                        </th>
                    </tr>
                    <tr style="font-size: 10px">
                        <td>
                            <asp:Image runat="server" ID="fullImg" ImageUrl="" />
                        </td>
                        <td>
                            Comp Plan Update
                        </td>
                        <td>
                            <asp:Label runat="server" ID="full" Text='<%# Bind("full") %>' />
                        </td>
                    </tr> 
                    <!-- 
                    <tr style="font-size: 10px">
                        <td>
                            <asp:Image runat="server" ID="partialImg" ImageUrl="" />
                        </td>
                      
                        <td>
                            Solid Waste Capacity Assurance
                        </td>
                        <td>
                            <asp:Label runat="server" ID="swmp" />
                        </td>
                    </tr>
                    -->
                    <tr style="font-size: 10px">
                        <td>
                            <asp:Image runat="server" ID="cieImg" ImageUrl="" />
                        </td>
                        <td>
                            CIE Update
                        </td>
                        <td>
                            <asp:Label runat="server" ID="cie" />
                        </td>
                    </tr>
                    <tr style="font-size: 10px">
                        <td>
                            <asp:Image runat="server" ID="sdsImg" ImageUrl="" />
                        </td>
                        <td>
                            Service Delivery Strategy
                        </td>
                        <td>
                            <asp:Label runat="server" ID="sds" />
                        </td>
                    </tr>
                </table>
            </div>
            <span style="font-size: x-small">
                <asp:Image ID="Image1" runat="server" ImageUrl="~/images/green_ball.gif" />Compliant
                <asp:Image ID="Image2" runat="server" ImageUrl="~/images/yellow_ball.gif" />Due
                in less than 120 days
                <asp:Image ID="Image3" runat="server" ImageUrl="~/images/red_ball.gif" />Past Due
            </span>
        </div>
        
        <div style="width: 50%;" class="miniContent">
            <span style="color: #993300"><b>Planning Documents</b></span>
            <div style="width: 99%; border: solid Black thin; background-color: #fff;
                height: 160px;">
                <table width="100%" style="text-align: center; height: 20px;"><tr>
                    <th style="color: #007171; font-family: Tahoma; font-size: small; height: 20px;">&nbsp;</th></tr></table>
                
            <br />
            <br />
	        <asp:HyperLink ID="lnkCurrentPlans" runat="server" NavigateUrl="https://www.dca.ga.gov/node/1962/documents/2088" Target="_blank">Current Comprehensive Plans</asp:HyperLink>
            <br />
            <br />
            
            <%--<asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="~/Construction.aspx">Capital Improvement Element</asp:HyperLink>
            <br />
            <br />
            asp:HyperLink ID="HyperLink5" runat="server" NavigateUrl="~/Construction.aspx">Partial Update</asp:HyperLink>
            <br />
            <br /--%>
            <asp:HyperLink ID="HyperLink6" runat="server" NavigateUrl="https://www.dca.ga.gov/node/2111/documents/2088">Service Delivery Strategy</asp:HyperLink>
        </div>
	        <br />
            <br />
&nbsp;&nbsp;
        </div>    

		<!--New-->
        
        <div style="width: 45%; height: 203px;" class="miniContent">
            <span style="color: #993300"><b>Data for Planning</b></span>
            <div style="width: 100%; background-color: #fff;">
                <table style="border: solid Black thin; height: 162px;" width="100%">
                    <tr>
                        <td>
                            <table width="99%" border="0" style="text-align: left; height: 125px;">
                                <tr><td></td></tr>
                                <tr>
                                    <td style="height: 100px">
		                                <asp:HyperLink ID="hypQuickLinks" runat="server" Text="Quick Links" NavigateUrl="" Target="_blank" /><br />
                                        <asp:HyperLink ID="hypQuickFacts" runat="server" Text="Quick Facts" NavigateUrl="" Target="_blank" /><br />
		                                <asp:HyperLink ID="hypInfoSys" runat="server" Text="Detailed Census Information Request" NavigateUrl="http://www.georgiaplanning.com/CommunityReports.asp" Target="_blank" /><br />
		                                <asp:HyperLink ID="hypAmerFF" runat="server" Text="American Fact Finder" NavigateUrl="" Target="_blank" /><br />
		                                <asp:HyperLink ID="HyperLink11" runat="server" Text="Community Indicators" NavigateUrl="http://www.dca.ga.gov/commind/Sel1.asp" Target="_blank" /><br />
    		                            <asp:HyperLink ID="hypCountySnaps" runat="server" Text="County Snapshots" NavigateUrl="" Target="_blank" />
                                    </td>
                                </tr>
                             </table>
                        </td>
                    </tr>
                    <tr style="font-size: 10px">
                        <td>
                            &nbsp;</td>
                    </tr>
                    </table>
            </div>
        </div>
        
        <div style="width: 50%; height: 203px;" class="miniContent">
            <span style="color: #993300"><b>Other Community Information </b></span>&nbsp;
                <div style="width: 99%; border: solid Black thin; background-color: #fff;">
                    <table width="98%" border="0" style="text-align: left; height: 160px;">
                        <tr><td style="height: 124px">
		                        <asp:HyperLink ID="hypGACounty" runat="server" Text="Georgia.gov (city)" NavigateUrl="http://adel.georgia.gov/05/home/0,2230,8609945,00.html;jsessionid=7C8ED8852FF30B6CE6DEA7159D93C7A9" Target="_blank" />
		                        <asp:HyperLink ID="hypGACity" runat="server" Text="Georgia.gov (county)" NavigateUrl="" Target="_blank" /><br />
		                        <asp:HyperLink ID="hypGAEncyclopedia" runat="server" Text="New Georgia Encyclopedia" NavigateUrl="http://www.georgiaencyclopedia.org/nge/Categories.jsp?path=/CitiesCounties#/CitiesCounties" Target="_blank" /><br />
		                        <asp:HyperLink ID="hypAnnexRpts" runat="server" Text="Annexation Reports" NavigateUrl="" Target="_blank" /><br />
		                        <asp:HyperLink ID="hypGABestEx" runat="server" Text="Georgia’s best examples" NavigateUrl="" Target="_blank" /><br />
		                        <asp:HyperLink ID="HyperLink12" runat="server" Text="Georgia Government Officials " NavigateUrl="http://www.dca.ga.gov/dcacontacts/default.htm" Target="_blank" /><br />
		                        
    		                </td>
                        </tr>
                     </table>
               </div>       
	    	 </div>  
        </div>
    <asp:SqlDataSource ID="sdPlan" runat="server" ConnectionString="<%$ ConnectionStrings:DCA %>"
    SelectCommand="SELECT Next_Plan_Update FROM OPQG_planinfo2 WHERE FIPS=@fips OR @fips IS NULL" CancelSelectOnNullParameter="false">
    <SelectParameters>
        <asp:QueryStringParameter Name="fips" DbType = "String" Direction = "Input" QueryStringField="fips" DefaultValue="" ConvertEmptyStringToNull="True" />
        <asp:ControlParameter ControlID="full" Name="full" PropertyName="Text" Type="string" DefaultValue="" />
    </SelectParameters>
</asp:SqlDataSource>
    </asp:Content>
