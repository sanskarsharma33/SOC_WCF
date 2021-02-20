using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using FreelanceService.ModelClasses;

namespace FreelanceService.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IProjectRequestAlloted" in both code and config file together.
    [ServiceContract]
    public interface IProjectRequestAlloted
    {
        [OperationContract]
        string AllotProjectRequest(ProjectAlloatted projectAlloated);
        [OperationContract]
        string RemoveAllottedRequest(int id);
    }
}