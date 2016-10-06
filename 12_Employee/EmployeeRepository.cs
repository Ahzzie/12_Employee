using System;
using System.Linq;
using System.Collections.Generic;

namespace _12_Employee
{
    public class EmployeeRepository
    {
        private int id = 0;
        List<Employee> employees = new List<Employee>();

        public int NextId()
        {
            return ++id;
        }
        
        public void Clear()
        {
            employees.Clear();
        }

        public Employee CreateEmployee(string name, string type)
        {
            Employee employee = new Employee(name, type, NextId());
            employees.Add(employee);
            return employee;
        }

        public int CountEmployees()
        {
            return employees.Count;
        }

       public void SaveEmployee(Employee employee)
        {
            employees[employee.Id-1] = employee;
        }

        public Employee LoadEmployee(int id)
        {
            return employees[id-1];
        }

        public List<Employee> FindAllEmployees()
        {
            return employees;
        }
    }
}