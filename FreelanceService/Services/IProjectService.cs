using FreelanceService.ModelClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace FreelanceService.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IIProjectService" in both code and config file together.
    [ServiceContract]
    public interface IProjectService
    {
        [OperationContract]    
        string AddProject(Project proj);
            
        [OperationContract]
        IEnumerable<Project> GetProjects();
        
        [OperationContract]
        string UpdateProject(Project proj);
        
        [OperationContract]
        Project SearchProject(Project proj);

        [OperationContract]
        string DeleteProject(Project proj);

    }
}
