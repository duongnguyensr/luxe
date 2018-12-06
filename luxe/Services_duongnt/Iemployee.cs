using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Newtonsoft.Json;

namespace luxe.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "Iemployee" in both code and config file together.
    [ServiceContract]
    public interface Iemployee
    {
        [OperationContract]
        string Getall();

        [OperationContract]
        int Update(string data);

        [OperationContract]
        int Delete(string data);
    }
}
