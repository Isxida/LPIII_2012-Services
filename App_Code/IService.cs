using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService" in both code and config file together.
[ServiceContract]
public interface IService
{
    //Servicio de Usuarios (sino, como se logea, duuuh)
    [OperationContract]
    DataSet showUsuarios();

    [OperationContract]
    DataSet findUsuario(String dni);

    //Servicio de Instrumentos
    [OperationContract]
    DataSet showInstrumentos();

    [OperationContract]
    DataSet findInstrumento(String cod);

    //Servicio de Studios
    [OperationContract]
    DataSet showStudios();

    [OperationContract]
    DataSet findStudio(String cod);

    //Servicio de Reserva
    [OperationContract]
    DataSet showReservas();

    [OperationContract]
    DataSet findReserva(String dni);

}


