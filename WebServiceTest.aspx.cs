using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WebServiceTest : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        CountyService myCountyService = new CountyService();
        test.Text = myCountyService.getPopulationData().American_Indian.ToString();
    }
}
