using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

public partial class DataForPlanning : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        String community;
        try
        {
            community = Session["fips"].ToString();
            

            if ((community == "none") || (community == "") || (community == null))
            {
                Response.Redirect("~/CommunitySelection.aspx");
            }
            else
            {
                if (Session["Juris"].ToString() == "County")
                {
                    hypQuickLinks.NavigateUrl = "http://quickfacts.census.gov/qfd/states/13/" + Session["fips"] + "lk.html";
                    hypQuickLinks.Text = "Quick Links for " + Session["com"] + " County";

                    hypQuickFacts.NavigateUrl = "http://quickfacts.census.gov/qfd/states/13/" + Session["fips"] + ".html";
                    hypQuickFacts.Text = "Quick Facts for " + Session["com"] + " County";
                }
                else
                {
                    hypQuickLinks.NavigateUrl = "http://quickfacts.census.gov/qfd/states/13/" + Session["fips"] + "lk.html";
                    hypQuickLinks.Text = "Quick Links for " + Session["com"] + " City";

                    hypQuickFacts.NavigateUrl = "http://quickfacts.census.gov/qfd/states/13/" + Session["fips"] + ".html";
                    hypQuickFacts.Text = "Quick Facts for " + Session["com"] + " City";
                }
            }            
        }
        catch
        {
            Response.Redirect("~/CommunitySelection.aspx");
        }

        //comm.Value = Session["com"].ToString();
        //juris.Value = Session["juris"].ToString();
    }
}
