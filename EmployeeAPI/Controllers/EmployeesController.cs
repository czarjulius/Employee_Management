﻿using EmployeeDataAccess;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace EmployeeAPI.Controllers
{
    public class EmployeesController : ApiController
    {
        public IEnumerable<Employee> Get()
        {
            using(EmployeeDBEntities entities = new EmployeeDBEntities())
            {
                return entities.Employees.ToList();
            }
        }

        public Employee Get(int id)
        {
            using(EmployeeDBEntities entities = new EmployeeDBEntities())
            {

                return entities.Employees.FirstOrDefault(x => x.ID == id);
            }
        }
    }
}
