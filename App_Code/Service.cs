using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class Service : IService
{
    private SqlConnection cn = new SqlConnection("server=.; database=Comercial2012; uid=sa; pwd=sql");

    System.Data.DataSet IService.showUsuarios()
    {
        SqlDataAdapter da = new SqlDataAdapter("Select * from Usuarios", cn);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;
    }

}
