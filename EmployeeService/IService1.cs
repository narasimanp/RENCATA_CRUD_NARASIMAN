using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace EmployeeService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        List<tblEmployee> GetEmployees();

        [OperationContract]
        tblEmployee GetAllEmployeeById(int id);

        [OperationContract]
        int AddEmployee(int Id, string Name, string Email, string Phone, string Gender);

        [OperationContract]
        int UpdateEmployee(int Id, string Name, string Email, string Phone, string Gender);

        [OperationContract]
        int DeleteEmployeeById(int Id);

    }


  
}
