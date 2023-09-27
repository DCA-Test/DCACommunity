using System.Web.Services;
using System.Web.Script.Services;
using System.Collections.Generic;
using System;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Web.Configuration;

[WebService(Namespace = "http://localhost/", Name = "CountyService")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
[ScriptService]
public class CountyService : WebService
{
    [WebMethod]
    public ReturnInfo getPopulationData()
    {
        ReturnInfo RI = new ReturnInfo();
        DCATableAdapters.PopulationTableAdapter adapter = new DCATableAdapters.PopulationTableAdapter();
        DCA.PopulationDataTable datatbl;
        datatbl = adapter.GetDataByFIPS("13001");
        foreach (DCA.PopulationRow row in datatbl)
        {
            RI.Id = row.Id.ToString();
            RI.Name = row.Name.ToString();
            RI.Total_Population = row.Total_Population.ToString();
            RI.White = row.White.ToString();
            RI.Black_African_American = row.Black_African_American.ToString();
            RI.American_Indian = row.American_Indian.ToString();
            RI.Asian = row.Asian.ToString();
            RI.Pacific_Islander = row.Pacific_Islander.ToString();
            RI.Other = row.Other.ToString();
            RI.Two_more_races = row.Two_more_races.ToString();
            RI.Hispanic_Latino = row.Hispanic_Latino.ToString();
        }
        return RI;
    }

}


