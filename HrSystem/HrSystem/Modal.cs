using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrSystem
{
    class Modal
    {
        public ObservableCollection<Department> Departments { get; private set; }
        public ObservableCollection<Employee> Employees { get; private set; }


        public Department CreateDepartment(string name = null)
        {
            var dep = new Department(name);
            Departments.Add(dep);
            return dep;
        }
        public Employee CreateEmployee(string firstName, string lastName, Department dep)
        {
            var empl = new Employee(firstName, lastName, dep);
            Employees.Add(empl);
            return empl;
        }

        public Modal()
        {
            Random rnd = new Random();
            Departments = new ObservableCollection<Department>();
            //создаем список из 5 департаментов
            for (int i = 0; i < 5; i++) { CreateDepartment("department " + rnd.Next(0, 5)); }

            Employees = new ObservableCollection<Employee>();
            //создаем список из 20 сотрудников
            for (int i = 0; i < 20; i++)
            {
                CreateEmployee("robot" + i, "machine" + i, Departments[rnd.Next(0, 5)]);
            }

        }
        //фильтр по департаменту
        public List<Employee> GetEmployeesByDep(Department dep)
        {
            return
               Employees.Where(e => e.Department.Name == dep.Name).ToList();

        }
    }
}
