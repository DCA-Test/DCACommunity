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

public partial class Action : System.Web.UI.Page
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
        }
        catch
        {
            Response.Redirect("~/CommunitySelection.aspx");
        }

        if (Session["juris"].ToString() == "County")
        {
            HyperLink1.Text = "Area Planner Contact Info for " + Session["com"] + " County";
            HyperLink2.Text = "Technical Assistance Contact Info for " + Session["com"] + " County";
            HyperLink3.Text = "Regional Representative Contact Info for " + Session["com"] + " County";
            HyperLink5.Text = "Regional Commission Contact Info for " + Session["com"] + " County";
        }
        else
        {
            HyperLink1.Text = "Area Planner Contact Info";
            HyperLink2.Text = "Technical Assistance Contact Info";
            HyperLink3.Text = "Regional Representative Contact Info";
            HyperLink5.Text = "Regional Commission Contact Info";
        }
    }
}
