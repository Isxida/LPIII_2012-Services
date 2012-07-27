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
    

    //Metodos showObject
    System.Data.DataSet IService.showUsuarios()
    {
        SqlDataAdapter da = new SqlDataAdapter("Select * from Usuarios", cn);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;
    }

    System.Data.DataSet IService.showInstrumentos()
    {
        SqlDataAdapter da = new SqlDataAdapter("Select * from Instrumentos", cn);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;
    }
    
    System.Data.DataSet IService.showReservas()
    {
        SqlDataAdapter da = new SqlDataAdapter("Select * from Reservas", cn);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;
    }
    
    System.Data.DataSet IService.showStudios()
    {
        SqlDataAdapter da = new SqlDataAdapter("Select * from Studios", cn);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;
    }

    //Metodos findObject
    System.Data.DataSet IService.findUsuario(String dni)
    {
        SqlDataAdapter da = new SqlDataAdapter("Select * from Usuario where dni=@dni", cn);
        da.SelectCommand.Parameters.Add("@dni", SqlDbType.VarChar).Value = dni;
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;
    }
    System.Data.DataSet IService.findStudio(String cod)
    {
        SqlDataAdapter da = new SqlDataAdapter("Select * from Studio where codigo=@cod", cn);
        da.SelectCommand.Parameters.Add("@cod", SqlDbType.VarChar).Value = cod;
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;
    }
    System.Data.DataSet IService.findReserva(String dni)
    {
        SqlDataAdapter da = new SqlDataAdapter("Select * from Reservas where dni=@dni", cn);
        da.SelectCommand.Parameters.Add("@dni", SqlDbType.VarChar).Value = dni;
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;
    }
    System.Data.DataSet IService.findInstrumento(String cod)
    {
        SqlDataAdapter da = new SqlDataAdapter("Select * from Instrumentos where codigo=@cod", cn);
        da.SelectCommand.Parameters.Add("@cod", SqlDbType.VarChar).Value = cod;
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;
    }

}
