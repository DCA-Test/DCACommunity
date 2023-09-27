using System;
using System.Collections;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using Telerik.Web.UI;

public partial class CommunityHomePage : System.Web.UI.Page
{
    private string NGE;
    protected void Page_Load(object sender, EventArgs e)
    {
        String communityFips;

        //Begin check selection
        try
        {
            if ((Request.QueryString["fips"] != "") && (Request.QueryString["fips"] != null))
            {
                Session["fips"] = Request.QueryString["fips"];
                DCATableAdapters.CountyTableAdapter countyAdapter = new DCATableAdapters.CountyTableAdapter();
                DCA.CountyDataTable county;
                county = countyAdapter.GetCountyByFIPS(Session["fips"].ToString());

                int index = 0;

                foreach (DCA.CountyRow countyRow in county)
                {
                    if (index == 0)
                    {
                        Session["com"] = countyRow.Gov_Name;
                        Session["juris"] = countyRow.Gov_Type;
                        Session["cicoid"] = countyRow.CICOID;
                    }
                }
            }
            else
            {
                Response.Redirect("~/Default.aspx");
            }

            //End check selection

            //Set map image
            if (!Page.IsPostBack)
            {
                //if (Session["juris"].ToString() != "County" && Request.QueryString["juris"] != "County")
                //{
                //    map.ImageUrl = "~/images/Group1/" + Request.QueryString["fips"].Remove(0, 2) + ".png";
                //}
                //else
                //{
                //    map.ImageUrl = "~/images/Group1/" + Request.QueryString["fips"] + ".png";
                //}
                //map.Height = 150;
            }

			DCATableAdapters.OPQG_planinfo2TableAdapter adapter = new DCATableAdapters.OPQG_planinfo2TableAdapter();
			DCA.OPQG_planinfo2DataTable datatbl;
			datatbl = adapter.GetDataByFIPS(Request.QueryString["fips"].ToString());

			string planFips = "";
			foreach (DCA.OPQG_planinfo2Row row in datatbl)
			{
				if (!row.IsNull("PlanFIPS"))
				{
					planFips = row.PlanFIPS;
				}
			}

            //lnkExtraData.NavigateUrl = "http://www.georgiaplanning.com/dataviews/acs/dv0.asp?Jurisdiction=County&FIPS=" + Request.QueryString["fips"] + "&Name=" + Session["com"];
			//lnkCurrentPlans.NavigateUrl = lnkCurrentPlans.NavigateUrl + planFips;
        }
        catch
        {
            Response.Redirect("~/Default.aspx");
        }
        //End set map image

		communityFips = Session["fips"].ToString();
		if ((communityFips == "none") || (communityFips == "") || (communityFips == null))
        {
            Response.Redirect("~/CommunitySelection.aspx");
        }

        //Mathew 12/17/2012: Moved all Connect link(About.aspx) items to this page

        string community;

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
                    hypGACounty.NavigateUrl = "http://" + Session["com"] + "county.georgia.gov";
                    hypGACounty.Text = "Georgia.gov for " + Session["com"] + " County";
                    hypGACity.Visible = false;
                    if (NGE != "")
                    {
                        hypGAEncyclopedia.NavigateUrl = "http://www.georgiaencyclopedia.org/nge/Article.jsp?path=/CitiesCounties/Counties&id=h-" + NGE;
                        hypGAEncyclopedia.Text = "New Georgia Encyclopedia for " + Session["com"] + " County";
                    }
                    hypAmerFF.NavigateUrl = "http://factfinder.census.gov/servlet/SAFFFacts?_event=Search&geo_id=05000US13143&_geoContext=01000US%7C04000US13%7C05000US13143&_street=&_county=" + Session["com"].ToString() + " County+County&_cityTown=" + Session["com"].ToString() + " County+County&_state=04000US13&_zip=&_lang=en&_sse=on&ActiveGeoDiv=geoSelect&_useEV=&pctxt=fph&pgsl=050";
                    hypAmerFF.Text = "American Fact Finder for " + Session["com"] + " County";
                    hypAnnexRpts.NavigateUrl = "http://www.georgiaplanning.com/boundary/annexations/showcounty.asp?FIPS=" + Request.QueryString["fips"].ToString() + "&CountyNAME=" + Session["com"];
                    hypAnnexRpts.Text = "Annexation Reports for " + Session["com"] + " County";
                    hypCountySnaps.NavigateUrl = "http://www.dca.ga.gov/CountySnapshotsNet/countysnapshot.aspx?cicoid=" + Session["cicoid"];
                    hypCountySnaps.Text = "County Snapshot for " + Session["com"] + " County";
                    //hypGABestEx.NavigateUrl = "http://www.dca.ga.gov/toolkit/ProcessMapSearch.asp?County=" + Session["com"];
                    hypGABestEx.NavigateUrl = "http://www.dca.ga.gov/toolkit/ProcessExamplesSearch.asp?type=m&gov=" + Session["fips"];
                    hypGABestEx.Text = "Georgia's Best Examples for " + Session["com"] + " County";
                }
                else
                {
                    hypGACity.NavigateUrl = "http://" + Session["com"] + ".georgia.gov";
                    hypGACity.Text = "Georgia.gov for the City of " + Session["com"];
                    hypGACounty.Visible = false;
                    hypGACounty.Visible = false;
                    if (NGE != "")
                    {
                        hypGAEncyclopedia.NavigateUrl = "http://www.georgiaencyclopedia.org/nge/Article.jsp?path=/CitiesCounties/Cities&id=h-" + NGE;
                        hypGAEncyclopedia.Text = "New Georgia Encyclopedia for the City of " + Session["com"];
                    }
                    hypAmerFF.NavigateUrl = "http://factfinder.census.gov/servlet/SAFFFacts?_event=Search&geo_id=05000US13143&_geoContext=01000US%7C04000US13%7C05000US13143&_street=&_county=" + Session["com"].ToString() + "&_cityTown=" + Session["com"].ToString() + "&_state=04000US13&_zip=&_lang=en&_sse=on&ActiveGeoDiv=geoSelect&_useEV=&pctxt=fph&pgsl=050";
                    hypAmerFF.Text = "American Fact Finder for the City of " + Session["com"];
                    hypAnnexRpts.NavigateUrl = "http://www.georgiaplanning.com/boundary/annexations/showcounty.asp?FIPS=" + Request.QueryString["fips"].ToString() + "&CountyNAME=" + Session["com"];
                    hypAnnexRpts.Text = "Annexation Reports for the City of " + Session["com"];
                    //hypGABestEx.NavigateUrl = "http://www.dca.ga.gov/toolkit/ProcessMapSearch.asp?City=" + Session["com"];
                    hypGABestEx.NavigateUrl = "http://www.dca.ga.gov/toolkit/ProcessExamplesSearch.asp?type=m&gov=" + Session["fips"];
                    hypGABestEx.Text = "Georgia's Best Examples for the City of " + Session["com"];
                }
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

        setDashboard();
        setLinks();
    }

    protected void setDashboard()
    {
        //Begin get dates
        DCATableAdapters.OPQG_planinfo2TableAdapter adapter = new DCATableAdapters.OPQG_planinfo2TableAdapter();
        DCA.OPQG_planinfo2DataTable datatbl;
        datatbl = adapter.GetDataByFIPS(Request.QueryString["fips"].ToString());

        DateTime[] dashDates = new DateTime[4];

        DataView dview = (DataView)sdPlan.Select(DataSourceSelectArguments.Empty);
        DateTime planValue = (DateTime)dview.Table.Rows[0]["Next_Plan_Update"];

        foreach (DCA.OPQG_planinfo2Row row in datatbl)
        {
            //----------------------------------------
            //Commented by eldhose on 11/09/2018
            //if (!row.IsNull("Next Full Update"))
            //{
            //    dashDates[0] = Convert.ToDateTime(row.Next_Full_Update);
            //    full.Text = row.Next_Full_Update;
            //}
            full.Text = planValue.ToShortDateString();
            //Added by eldhose on 11/09/2018
            //if (!row.IsNull("Computed_Due"))
            //{
            //    dashDates[0] = Convert.ToDateTime(row.Computed_Due);               
            //    full.Text = dashDates[0].ToString("MM/dd/yyyy");
            //}
            //----------------------------------------

            if (!row.IsNull("Next_SWMP"))
            {
                dashDates[1] = Convert.ToDateTime(row.Next_SWMP);
                swmp.Text = row.Next_SWMP;
            }
            if (!row.IsNull("Next CIE"))
            {
                dashDates[2] = Convert.ToDateTime(row.Next_CIE);
                cie.Text = row.Next_CIE;
            }
            if (!row.IsNull("Next SDS"))
            {
                dashDates[3] = Convert.ToDateTime(row.Next_SDS);
                sds.Text = row.Next_SDS;
            }
        }
        //End get Dates

        //Set images
        String[] images = new String[4];
        TimeSpan daysDiff;

        for (int i = 0; i < 4; i++)
        {
            daysDiff = dashDates[i].Subtract(DateTime.Now);
            if ((dashDates[i] < DateTime.Now) && (!dashDates[i].ToString().Contains("1/1/0001")))
            {
                images[i] = "~/images/red_ball.gif";
            }
            else if ((daysDiff.Days < 120) && (daysDiff.Days > 0))
            {
                images[i] = "~/images/yellow_ball.gif";
            }
            else if (!dashDates[i].ToString().Contains("1/1/0001"))
            {
                images[i] = "~/images/green_ball.gif";
            }
            else
            {
                images[i] = "";
            }
        }

        String[] imageUrls = { "fullImg", "partialImg", "cieImg", "sdsImg" };
        for (int i = 0; i < 4; i++)
        {
            Image img = (Image)FindControlRecursive(Page, imageUrls[i]);
            if (images[i] != "")
            {
                img.ImageUrl = images[i];
            }
            else { img.Visible = false; }
        }
        //End set Images

        //Set demographic data
        foreach (DCA.OPQG_planinfo2Row row in datatbl)
        {
            //if (!row.IsNull("Population"))
            //{
            //    populationLbl.Text = String.Format("{0:0,0}", row.Population);
            //}
            //else
            //{
            //    populationLbl.Text = "N/A";
            //}

            //if (!row.IsNull("HomeownershipRate"))
            //{
            //    homeownerLbl.Text = String.Format("{0:F1}", row.HomeownershipRate) + "%";
            //}
            //else
            //{
            //    homeownerLbl.Text = "N/A";
            //}

            //if (!row.IsNull("PerCapitaIncome"))
            //{
            //    percapitaLbl.Text = String.Format("{0:C}", row.PerCapitaIncome);
            //}
            //else
            //{
            //    percapitaLbl.Text = "N/A";
            //}

        }
        //End Set Demographic Data

        // Start timeline creation.
        RadScheduler timeline = new RadScheduler();
        timeline.ID = "rsTimeline";
        timeline.AppointmentDataBound += new AppointmentDataBoundEventHandler(rsTimeline_AppointmentDataBound);

        DataTable timelineData = new DataTable();
        timelineData.Columns.Add("ID");
        timelineData.Columns.Add("Start");
        timelineData.Columns.Add("End");
        timelineData.Columns.Add("Subject");

        timelineData.Rows.Add(1, dashDates[0], dashDates[0], "Comp Plan Update");
        timelineData.Rows.Add(2, dashDates[1], dashDates[1], "Solid Waste Capacity Assurance");
        timelineData.Rows.Add(4, dashDates[2], dashDates[2], "CIE Update");
        timelineData.Rows.Add(5, dashDates[3], dashDates[3], "Service Delivery Strategy");

        timeline.DataSource = timelineData;
        timeline.DataKeyField = "ID";
        timeline.DataStartField = "Start";
        timeline.DataEndField = "End";
        timeline.DataSubjectField = "Subject";

        DateTime timelineStartDate = dashDates[0];
        foreach (DateTime current in dashDates)
        {
            if (current != null && current.CompareTo(timelineStartDate) < 0 && !current.Equals(new DateTime()))
            {
                timelineStartDate = current;
            }
        }
        if (timelineStartDate.Equals(new DateTime()))
        {
            timeline.SelectedDate = DateTime.Today;
        }
        else
        {
            timeline.SelectedDate = timelineStartDate.AddDays(-4);
        }

        //timeline.DayView.UserSelectable = false;
        //timeline.WeekView.UserSelectable = false;
        //timeline.MonthView.UserSelectable = false;
        timeline.ReadOnly = true;
        timeline.ColumnWidth = 150;
        timeline.TimelineView.NumberOfSlots = 200;
        timeline.SelectedView = SchedulerViewType.TimelineView;
        timeline.ShowViewTabs = false;
        timeline.OverflowBehavior = OverflowBehavior.Expand;

        //pnlTimeline.Controls.Add(timeline);
    }

    private DataView CType(IEnumerable enumerable, DataView dataView)
    {
        throw new NotImplementedException();
    }

    protected void rsTimeline_AppointmentDataBound(object sender, SchedulerEventArgs e)
    {
        if (!e.Appointment.Start.Equals(new DateTime()))
        {
            if (e.Appointment.Start.CompareTo(DateTime.Today) < 0)
            {
                e.Appointment.BackColor = System.Drawing.Color.DarkRed;
                e.Appointment.ForeColor = System.Drawing.Color.White;
                e.Appointment.BorderStyle = BorderStyle.Dotted;
                e.Appointment.BorderColor = System.Drawing.Color.Black;
                e.Appointment.BorderWidth = Unit.Pixel(2);
            }
            else if ((e.Appointment.Start.Subtract(DateTime.Now)).Days < 120 && (e.Appointment.Start.Subtract(DateTime.Now)).Days > 0)
            {
                e.Appointment.BackColor = System.Drawing.Color.Gold;
                e.Appointment.ForeColor = System.Drawing.Color.Black;
                e.Appointment.BorderStyle = BorderStyle.Dotted;
                e.Appointment.BorderColor = System.Drawing.Color.Black;
                e.Appointment.BorderWidth = Unit.Pixel(1);
            }
            else
            {
                e.Appointment.BackColor = System.Drawing.Color.LightGreen;
                e.Appointment.ForeColor = System.Drawing.Color.Black;
                e.Appointment.BorderStyle = BorderStyle.Dotted;
                e.Appointment.BorderColor = System.Drawing.Color.Black;
                e.Appointment.BorderWidth = Unit.Pixel(1);
            }
        }
    }

    private Control FindControlRecursive(Control root, string id)
    {
        if (root.ID == id)
        {
            return root;
        }
        foreach (Control c in root.Controls)
        {
            Control t = FindControlRecursive(c, id);
            if (t != null)
            {
                return t;
            }
        }
        return null;
    }

    protected void Timer1_Tick(String direction)
    {
        //string curGrp;
        //int index;
        //string fips;

        //if (Session["juris"].ToString() != "County")
        //{
        //    fips = Request.QueryString["fips"].Remove(0, 2);
        //    curGrp = map.ImageUrl.Replace("~/images/Group", "");
        //    curGrp = curGrp.Replace("/" + fips + ".png", "");
        //    index = Convert.ToInt32(curGrp);
        //    if (direction == "back")
        //    {
        //        index = index - 1;
        //        if (index == 0)
        //        {
        //            index = 3;
        //        }
        //    }
        //    else
        //    {
        //        index++;
        //        if (index == 3)
        //        {
        //            index = 1;
        //        }
        //    }
        //    map.ImageUrl = "~/images/Group" + index + "/" + fips + ".png";
        //}
        //else
        //{
        //    curGrp = map.ImageUrl.Replace("~/images/Group", "");
        //    curGrp = curGrp.Replace("/" + Request.QueryString["fips"] + ".png", "");
        //    index = Convert.ToInt32(curGrp);
        //    if (direction == "back")
        //    {
        //        index = index - 1;
        //        if (index == 0)
        //        {
        //            index = 3;
        //        }
        //    }
        //    else
        //    {
        //        index++;
        //        if (index == 4)
        //        {
        //            index = 1;
        //        }
        //    }
        //    map.ImageUrl = "~/images/Group" + index + "/" + Request.QueryString["fips"] + ".png";
        //}
        //map.Height = 150;
    }

    protected void setLinks()
    {
        DCATableAdapters.LinksTableAdapter adapter = new DCATableAdapters.LinksTableAdapter();
        DCA.LinksDataTable links;
        links = adapter.GetLinksByFIPS(Request.QueryString["fips"].ToString());

		/*
        foreach (DCA.LinksRow row in links)
        {
            if (!row.IsNull("Assessment"))
            {
                CommAssess.NavigateUrl = row.Assessment;
            }
            if (!row.IsNull("Agenda"))
            {
                CommAg.NavigateUrl = row.Agenda;
            }
            if (!row.IsNull("CPP"))
            {
                CPPlink.NavigateUrl = row.CPP;
            }

        }
		*/
    }

    protected void Timer1_TickBack(object sender, EventArgs e)
    {
        Timer1_Tick("back");
    }

    protected void Timer1_TickForw(object sender, EventArgs e)
    {
        Timer1_Tick("Forward");
    }


}