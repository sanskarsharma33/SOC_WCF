using FreelanceService.ModelClasses;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace FreelanceService.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IUserService" in both code and config file together.
    [ServiceContract]
    public interface IUserService
    {
        [OperationContract]
        string CreateUser(User user);

        [OperationContract]
        DataSet ViewUser(int id);

        [OperationContract]
        DataSet AllUsers();
    }
}
