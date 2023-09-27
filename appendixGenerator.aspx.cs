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

public partial class appendixGenerator : System.Web.UI.Page
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

        comm.Value = Session["com"].ToString();
        juris.Value = Session["juris"].ToString();
    }

}
