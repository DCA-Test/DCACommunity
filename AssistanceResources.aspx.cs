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

public partial class AssisstanceResources : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        String community;
        community = Session["community"].ToString();
        CommName.Text = community;
    }
}
