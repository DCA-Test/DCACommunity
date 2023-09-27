using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web.Security;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Web.Configuration;
using System.Data.SqlClient;
using System.Text;

public partial class About : System.Web.UI.Page
{
    public string NGE;
    protected void Page_Load(object sender, EventArgs e)
    {
        String community;

        try
        {
            community = Session["fips"].ToString();

            DCATableAdapters.ID_LookupTableAdapter adapter = new DCATableAdapters.ID_LookupTableAdapter();
            DCA.ID_LookupDataTable idlu;
            idlu = adapter.GetIDsByFIPS(Request.QueryString["fips"].ToString());


            foreach (DCA.ID_LookupRow idRow in idlu)
            {
                try
                {
                    NGE = idRow.NGEID;
                }
                catch
                {
                    NGE = "";
                }

            }

            if ((community == "none") || (community == "") || (community == null))
            {
                Response.Redirect("~/CommunitySelection.aspx");
            }
            else
            {
                if (Session["juris"].ToString() == "County")
                {
                    HyperLink2.NavigateUrl = "http://" + Session["com"] + "county.georgia.gov";
                    HyperLink2.Text = "Georgia.gov for " + Session["com"] + " County";
                    HyperLink1.Visible = false;
                    if (NGE != "")
                    {
                        HyperLink4.NavigateUrl = "http://www.georgiaencyclopedia.org/nge/Article.jsp?path=/CitiesCounties/Counties&id=h-" + NGE;
                        HyperLink4.Text = "New Georgia Encyclopedia for " + Session["com"] + " County";
                    }
                    HyperLink5.NavigateUrl = "http://factfinder.census.gov/servlet/SAFFFacts?_event=Search&geo_id=05000US13143&_geoContext=01000US%7C04000US13%7C05000US13143&_street=&_county=" + Session["com"].ToString() + " County+County&_cityTown=" + Session["com"].ToString() + " County+County&_state=04000US13&_zip=&_lang=en&_sse=on&ActiveGeoDiv=geoSelect&_useEV=&pctxt=fph&pgsl=050";
                    HyperLink5.Text = "American Fact Finder for " + Session["com"] + " County";
                    HyperLink6.NavigateUrl = "http://www.georgiaplanning.com/boundary/annexations/showcounty.asp?FIPS=" + Request.QueryString["fips"].ToString() + "&CountyNAME=" + Session["com"];
                    HyperLink6.Text = "Annexation Reports for " + Session["com"] + " County";
                    HyperLink7.NavigateUrl = "http://dca.ga.gov/CountySnapshotsNet/countysnapshot.aspx?cicoid=" + Session["cicoid"];
                    HyperLink7.Text = "County Snapshot for " + Session["com"] + " County";
                    HyperLink9.NavigateUrl = "http://dca.ga.gov/toolkit/ProcessMapSearch.asp?County=" + Session["com"];
                    HyperLink9.Text = "Georgia's Best Examples for " + Session["com"] + " County";
                }
                else
                {
                    HyperLink1.NavigateUrl = "http://" + Session["com"] + ".georgia.gov";
                    HyperLink1.Text = "Georgia.gov for the City of " + Session["com"];
                    HyperLink2.Visible = false;
                    HyperLink7.Visible = false;
                    if (NGE != "")
                    {
                        HyperLink4.NavigateUrl = "http://www.georgiaencyclopedia.org/nge/Article.jsp?path=/CitiesCounties/Cities&id=h-" + NGE;
                        HyperLink4.Text = "New Georgia Encyclopedia for the City of " + Session["com"];
                    }
                    HyperLink5.NavigateUrl = "http://factfinder.census.gov/servlet/SAFFFacts?_event=Search&geo_id=05000US13143&_geoContext=01000US%7C04000US13%7C05000US13143&_street=&_county=" + Session["com"].ToString() + "&_cityTown=" + Session["com"].ToString() + "&_state=04000US13&_zip=&_lang=en&_sse=on&ActiveGeoDiv=geoSelect&_useEV=&pctxt=fph&pgsl=050";
                    HyperLink5.Text = "American Fact Finder for the City of " + Session["com"];
                    HyperLink6.NavigateUrl = "http://www.georgiaplanning.com/boundary/annexations/showcounty.asp?FIPS=" + Request.QueryString["fips"].ToString() + "&CountyNAME=" + Session["com"];
                    HyperLink6.Text = "Annexation Reports for the City of " + Session["com"];
                    HyperLink9.NavigateUrl = "http://dca.ga.gov/toolkit/ProcessMapSearch.asp?City=" + Session["com"];
                    HyperLink9.Text = "Georgia's Best Examples for the City of " + Session["com"];
                }
                
                
                
            }
        }
        catch
        {
            Response.Redirect("~/CommunitySelection.aspx");
        }
    }
}