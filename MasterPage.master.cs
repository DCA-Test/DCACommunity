using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using System.Web.Configuration;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;
using System.Text;
using System.Web.SessionState;

public partial class MasterPage : System.Web.UI.MasterPage
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

        try
        {
            string comName = Request.QueryString["fips"];
            string url;
            if (comName != null)
            {                
                LinkButton1.PostBackUrl = "~/CommunityHomePage.aspx?fips=" + Request.QueryString["fips"];
                //LinkButton2.PostBackUrl = "~/appendixGenerator.aspx?fips=" + Request.QueryString["fips"];
                LinkButton2.PostBackUrl = "~/DataForPlanning.aspx?fips=" + Request.QueryString["fips"];
                LinkButton3.PostBackUrl = "~/planPrep.aspx?fips=" + Request.QueryString["fips"];
                LinkButton4.PostBackUrl = "~/Action.aspx?fips=" + Request.QueryString["fips"];
                LinkButton5.PostBackUrl = "~/map.aspx?fips=" + Request.QueryString["fips"];
                LinkButton6.PostBackUrl = "~/docs.aspx?fips=" + Request.QueryString["fips"];
                LinkButton7.PostBackUrl = "~/About.aspx?fips=" + Request.QueryString["fips"];
                
                url = Request.Url.ToString();
                string[] parts = url.Split('/');
                if (parts[4].Contains("CommunityHomePage"))
                {
                    LinkButton1.Style.Value = "color:red";
                }
                if (parts[4].Contains("appendixGenerator"))
                {
                    LinkButton2.Style.Value = "color:red";
                }
                if (parts[4].Contains("planPrep"))
                {
                    LinkButton3.Style.Value = "color:red";
                }
                if (parts[4].Contains("Action"))
                {
                    LinkButton4.Style.Value = "color:red";
                }
                if (parts[4].Contains("map"))
                {
                    LinkButton5.Style.Value = "color:red";
                }
                if (parts[4].Contains("docs"))
                {
                    LinkButton6.Style.Value = "color:red";
                }
                if (parts[4].Contains("About"))
                {
                    LinkButton7.Style.Value = "color:red";
                }

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
                sideMenu.Visible = true;
                topMenus.Visible = true;
                topMenus.Items.Clear();
                //topMenus.StaticMenuItemStyle.Width = 60;
                
                topMenus.Items.Add(new MenuItem("Home", "Home", "", "~/"));
                if (Session["juris"].ToString() == "County")
                {
                    topMenus.Items.Add(new MenuItem(Session["com"].ToString() + " County", Session["com"].ToString(), "", "~/CommunityHomePage.aspx?fips=" + Request.QueryString["fips"] + " ffff  "));
                }
                else
                {
                    topMenus.Items.Add(new MenuItem(Session["juris"].ToString() + " " + Session["com"].ToString(), Session["com"].ToString(), "", "~/CommunityHomePage.aspx?fips=" + Request.QueryString["fips"] + "  ssss   "));
                } 
                //topMenus.Items.Add(new MenuItem("  ", "    ", "","#"));
                //topMenus.Items.Add(new MenuItem("Profile", "Profile", "", "~/DataForPlanning.aspx?fips=" + Request.QueryString["fips"]));
               
                /*
                topMenu.Items.Add(new MenuItem("Profile", "Profile", "", "~/appendixGenerator.aspx?fips=" + Request.QueryString["fips"]));
                 * /
                topMenu.Items.Add(new MenuItem("Planning Assistance", "Plan", "", "~/planPrep.aspx?fips=" + Request.QueryString["fips"]));
				/*
                topMenu.Items.Add(new MenuItem("Action", "Action", "", "~/Action.aspx?fips=" + Request.QueryString["fips"]));
				topMenu.Items.Add(new MenuItem("Map", "Map", "", "~/map.aspx?fips=" + Request.QueryString["fips"]));
                topMenu.Items.Add(new MenuItem("Docs", "Docs", "", "~/docs.aspx?fips=" + Request.QueryString["fips"]));
				
                topMenus.Items.Add(new MenuItem("Connect", "Connect", "", "~/About.aspx?fips=" + Request.QueryString["fips"]));
                */
                topMenus.Items.Add(new MenuItem("Change Community", "ChangeCommunity", "", "~/communitySelection.aspx?fips=" + Request.QueryString["fips"]));
                topMenus.StaticMenuItemStyle.HorizontalPadding = 20;
                topMenus.DynamicMenuItemStyle.HorizontalPadding = 20;
            }
            else
            {
                //community.Text = "Georgia Communities Data";
                community.Text = "";
            } 
        }
        catch
        {
            Response.Redirect("~/CommunitySelection.aspx");
        }

        
        
    }
}