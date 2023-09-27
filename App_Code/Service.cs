using System;
using System.Web;
using System.Net;
using System.IO;
using System.Text;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Data.SqlClient;
using System.Xml;



public class Service 
{
    public Service (String xmlFile) 
    {
        String sqlConnection = "";
        XmlTextReader r = new XmlTextReader(xmlFile);
        while (r.Read())
        {
            if (r.NodeType == XmlNodeType.Element)
            {
                if(r.Name == "connectionString")
                    sqlConnection = r.ReadElementContentAsString();
                else if(r.Name == "cityLinkPage")
                    cityLink = r.ReadElementContentAsString();
                else if (r.Name == "tableName")
                    tableName = r.ReadElementContentAsString();
                else if (r.Name == "selectFields")
                    selectFields = r.ReadElementContentAsString();
                else if (r.Name == "whereField")
                    whereField = r.ReadElementContentAsString();

            }
        }
        r.Close();
        conn = GetConnection(sqlConnection);        
    }
    private SqlConnection conn;
    private String tableName, selectFields, whereField, cityLink;
    public string GetCityData(string countyName, string countyFips)
    {
        
        string sql = "SELECT "+selectFields
                    +" FROM " + tableName
                    +" WHERE "+whereField+" = " + countyFips + "";
        SqlDataReader dr = GetData(sql);
        StringBuilder sb = new StringBuilder();
        String chartFields = "";
        String chartLabel = ";";
        try
        {
            while (dr.Read())
            {
                string tmp = "<li><a href='CommunityHomePage.aspx?Jurisdiction=City&FIPS=" + dr[0].ToString().Trim() + "&Name=" + dr[1].ToString().Trim() + "'>" + dr[1].ToString().Trim() + "</li>";
                chartLabel += dr[1].ToString().Trim()+"| ";
                chartFields += dr.GetDouble(2).ToString().Trim() + ",";
                sb.Append(tmp);
            }
            chartLabel = chartLabel.Remove(chartLabel.Length - 2);
            chartFields = chartFields.Remove(chartFields.Length - 1);
            string[] fields = chartFields.Split(',');
            double[] fldValues = new double[fields.Length];
            double total = 0.0;
            for (int i = 0; i < fields.Length; i++)
            {
                total += Double.Parse(fields[i]);
                fldValues[i] = Double.Parse(fields[i]);
            }
            chartFields = ";";
            for (int i = 0; i < fldValues.Length; i++)
            {
                fldValues[i] = (fldValues[i] / total) * 100;
                chartFields += fldValues[i] + ",";
            }
            chartFields = chartFields.Remove(chartFields.Length - 1);
            sb.Append(chartLabel);
            sb.Append(chartFields);
            dr.Close();
            return sb.ToString();
        }
        catch (Exception exc)
        {
            throw new Exception("Error executing the query" + Environment.NewLine + exc.StackTrace); ;

        }
        finally
        {
            if (conn != null)
                conn.Close();
            if (dr != null)
                dr.Close();

        }

    }



    private SqlConnection GetConnection(String sqlConnection)
    {
        try
        {

            SqlConnection conn = new SqlConnection(sqlConnection);
            conn.Open();
            return conn;
        }
        catch (Exception sql)
        {

        }
        return null;
    }

    public SqlDataReader GetData(string sql)
    {

        SqlCommand cmd = new SqlCommand(sql, conn);
        SqlDataReader dr = cmd.ExecuteReader();

        return dr;

    }
}
