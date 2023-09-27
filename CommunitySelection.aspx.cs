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

public partial class CommunitySelection : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DCATableAdapters.CountyTableAdapter CountyAdapter = new DCATableAdapters.CountyTableAdapter();
        DCA.CountyDataTable counties;
        counties = CountyAdapter.GetCounties();
        foreach (DCA.CountyRow countyRow in counties)
            countyName.Items.Add(new ListItem(countyRow.Gov_Name, countyRow.FIPS));

        DCATableAdapters.CityTableAdapter CityAdapter = new DCATableAdapters.CityTableAdapter();
        DCA.CityDataTable cities;
        cities = CityAdapter.GetCities();
        foreach (DCA.CityRow cityRow in cities)
            cityName.Items.Add(new ListItem(cityRow.Gov_Name, cityRow.FIPS));

        if (Page.IsPostBack)
        {
            if (countyName.SelectedValue != "0")
            {
                Session["juris"] = "County";
                Response.Redirect("~/CommunityHomePage.aspx?fips=" + countyName.SelectedValue);
                Session["selected"] = countyName.SelectedValue;
            }
            if (cityName.SelectedValue != "0")
            {
                Session["juris"] = "City";
                Response.Redirect("~/CommunityHomePage.aspx?fips=" + cityName.SelectedValue);
            }
        }
        try
        {
            if (Request.QueryString["juris"] == "County")
            {
                Session["juris"] = "County";
            }
        }
        catch
        {
            Session["juris"] = "City";
        }
    }
}
