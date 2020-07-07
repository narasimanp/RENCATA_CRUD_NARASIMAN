using System;
using System.Data;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace EmployeeService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.

    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]

    public class Service1 : IService1
    {
        public List<tblEmployee> GetEmployees()
        {
            testingEntities objcontext = new testingEntities();
            var k = from n in objcontext.tblEmployees select n;
            return k.ToList<tblEmployee>();
        }

        public tblEmployee GetAllEmployeeById(int id)
        {
            testingEntities tstDb = new testingEntities();
            var lstEmp = from k in tstDb.tblEmployees where k.EmpId == id select k;

            tblEmployee emp = new tblEmployee();
            foreach (var item in lstEmp)
            {
                emp.EmpId = item.EmpId;
                emp.Name = item.Name;
                emp.Email = item.Email;
                emp.Phone = item.Phone;
                emp.Gender = item.Gender;
            }
            return emp;
        }

        public int AddEmployee(int Id,string Name, string Email, string Phone, string Gender)
        {
            testingEntities tstDb = new testingEntities();
            tblEmployee empdtl = new tblEmployee();
            empdtl.EmpId = Id;
            empdtl.Name = Name;
            empdtl.Email = Email;
            empdtl.Phone = Phone;
            empdtl.Gender = Gender;
            tstDb.tblEmployees.Add(empdtl);
            int Retval = tstDb.SaveChanges();
            return Retval;
        }

        public int UpdateEmployee(int Id, string Name, string Email, string Phone, string Gender)
        {
                testingEntities tstDb = new testingEntities();
                tblEmployee empdtl = new tblEmployee();
                empdtl.EmpId = Id;
                empdtl.Name = Name;
                empdtl.Email = Email;
                empdtl.Phone = Phone;
                empdtl.Gender = Gender;
                //tstDb.Entry(empdtl).State = System.Data.Entity.EntityState.Modified;
                tstDb.Entry(empdtl).State = EntityState.Modified;

            int Retval = tstDb.SaveChanges();
                return Retval;
        }

        public int DeleteEmployeeById(int Id)
        {
            testingEntities tstDb = new testingEntities();
            tblEmployee empdtl = new tblEmployee();
            empdtl.EmpId = Id;
            tstDb.Entry(empdtl).State = System.Data.Entity.EntityState.Deleted;
            int Retval = tstDb.SaveChanges();
            return Retval;
        }
    }
}
