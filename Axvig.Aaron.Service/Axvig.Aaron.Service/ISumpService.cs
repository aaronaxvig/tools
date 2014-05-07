using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Axvig.Aaron.Service
{
    [ServiceContract]
    public interface ISumpService
    {
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/{meters}")]
        int CreateReading(string meters);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "/{count}")]
        List<double> GetReadings(string count);
    }
}
