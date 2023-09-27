using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PlanningDataMaster : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.UserAgent.IndexOf("AppleWebKit") > 0) 
        { 
            if (Request.Browser.Adapters.Count > 0) 
            { 
                Request.Browser.Adapters.Clear(); 
                Response.Redirect(Page.Request.Url.AbsoluteUri); 
            } 
        }

        //community.Text = "Georgia Communities Data";
        community.Text = "";
  
         try
         {
            string comName = Request.QueryString["fips"];
            string url;
            if (comName != null)
            {
                DCATableAdapters.CountyTableAdapter countyAdapter = new DCATableAdapters.CountyTableAdapter();
                DCA.CountyDataTable county;
                county = countyAdapter.GetCountyByFIPS(Request.QueryString["fips"].ToString());

                int index = 0;

                foreach (DCA.CountyRow countyRow in county)
                {
                    if (index == 0)
                    {
                        Session["com"] = countyRow.Gov_Name;
                        Session["juris"] = countyRow.Gov_Type;
                        Session["cicoid"] = countyRow.CICOID;

                        if (countyRow.Gov_Type == "County")
                        {
                            community.Text = countyRow.Gov_Name + " " + countyRow.Gov_Type;
                        }
                        else
                        {
                            community.Text = countyRow.Gov_Type + " " + countyRow.Gov_Name;
                        }
                        index++;
                    }
                }
            }
         }

        catch
        {
            Response.Redirect("~/CommunitySelection.aspx");
        }
    }
}
