﻿using System;
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

public partial class PlanPrep : System.Web.UI.Page
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
    }
}
