using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace luxe.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "employee" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select employee.svc or employee.svc.cs at the Solution Explorer and start debugging.
    public class employee : Iemployee
    {
        public int Delete(string data)
        {
            throw new NotImplementedException();
        }

        public string Getall()
        {
            string sql = "select * from filmtype";
            SqlDataAdapter da = new SqlDataAdapter(sql, ConfigurationManager.ConnectionStrings["conString"].ToString());
            DataSet ds = new DataSet();
            da.Fill(ds, "data");
            return JsonConvert.SerializeObject(ds, Newtonsoft.Json.Formatting.Indented);
        }

        public int Update(string data)
        {
            throw new NotImplementedException();
        }
    }
}
