using EmployeeMVCApplication.EmployeeServiceReference;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//using WCFinMVCapp.Models;

namespace EmployeeMVCApplication.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        //private testingEntities db = new testingEntities();
        public ActionResult Index()
        {
            EmployeeServiceReference.Service1Client obj = new EmployeeServiceReference.Service1Client();

            return View(obj.GetEmployees());
        }

        public ActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Create(tblEmployee mdl)
        {
            EmployeeServiceReference.Service1Client obj = new EmployeeServiceReference.Service1Client();
           try
            {
                if(ModelState.IsValid)
                {
                    tblEmployee usr = new tblEmployee();
                    usr.EmpId = mdl.EmpId;
                    usr.Name = mdl.Name;
                    usr.Email = mdl.Email;
                    usr.Phone = mdl.Phone;
                    usr.Gender = mdl.Gender;

                    TempData["Msg"] = "Record inserted successfully!!!";
                    obj.AddEmployee(usr.EmpId, usr.Name, usr.Email, usr.Phone, usr.Gender);
                    return RedirectToAction("Create", "Employee");

                }
                else
                {
                    return View();
                }
            }
            catch(Exception ex)
            {
                TempData["Msg"] = "Please fill all the fields!!!.";
                return RedirectToAction("Create", "Employee");
            }
        }

        public ActionResult Edit(int id)
        {
             EmployeeServiceReference.Service1Client obj = new EmployeeServiceReference.Service1Client();

             var lst = obj.GetAllEmployeeById(id);
             tblEmployee usr = new tblEmployee();
             usr.EmpId = lst.EmpId;
             usr.Name = lst.Name;
             usr.Email = lst.Email;
             usr.Phone = lst.Phone;
             usr.Gender = lst.Gender;
             return View(usr);
        }

        [HttpPost]
        public ActionResult Edit(tblEmployee mdl)
        {
            EmployeeServiceReference.Service1Client obj = new EmployeeServiceReference.Service1Client();
            try
            {
                if (ModelState.IsValid)
                {
                    tblEmployee usr = new tblEmployee();
                    usr.EmpId = mdl.EmpId;
                    usr.Name = mdl.Name;
                    usr.Email = mdl.Email;
                    usr.Phone = mdl.Phone;
                    usr.Gender = mdl.Gender;
                    int Retval = obj.UpdateEmployee(usr.EmpId, usr.Name, usr.Email, usr.Phone, usr.Gender);
            
            if (Retval > 0)
            {
                return RedirectToAction("Create", "Employee");
            }
                }
            }
            catch (Exception ex)
            {
                TempData["Msg"] = "Please fill all the fields!!! " + ex.Message.ToString();
                return RedirectToAction("Create", "Employee");
            }
            return View();
        }

        public ActionResult Delete(int id)
        {
            EmployeeServiceReference.Service1Client obj = new EmployeeServiceReference.Service1Client();
            int retval = obj.DeleteEmployeeById(id);
            if (retval > 0)
            {
                return RedirectToAction("Index", "Employee");
            }

            return View();
        }

        [HttpGet]
        public ActionResult Details(int Id)
        {
            EmployeeServiceReference.Service1Client obj = new EmployeeServiceReference.Service1Client();

            return View(obj.GetAllEmployeeById(Id));
        }

    }
}