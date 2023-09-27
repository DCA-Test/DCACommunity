using System.Web.Services;
using System.Web.Script.Services;
using System.Collections.Generic;

[WebService]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
[ScriptService]
public class MapService : WebService
{
    [WebMethod]
    public string GetCityData(string countyName, string countyFips)
    {
        Service serv = new Service(Server.MapPath("~/config.xml"));
        return serv.GetCityData(countyName, countyFips);
    }
}


