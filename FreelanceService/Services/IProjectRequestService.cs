using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using FreelanceService.ModelClasses;


namespace FreelanceService.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IProjectRequestService" in both code and config file together.
    [ServiceContract]
    public interface IProjectRequestService
    {
        [OperationContract]
        void DoWork();

        [OperationContract]
        string AddProjectRequest(ProjectRequest projectRequest);

        [OperationContract]
        ProjectRequest ViewProjectRequest(int id);

        [OperationContract]
        DataTable ShowProjectRequests(int projectId);

        [OperationContract]
        string UpdateProjectRequest(ProjectRequest projectRequest);

    }
}
