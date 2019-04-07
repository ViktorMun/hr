namespace HrSystem
{
     class Employee
    {
       
            public string Name { get; set; }
            public string LastName { get; set; }
            public Department Department { get; set; }

            public Employee(string name, string lastName, Department department)
            {
                Name = name;
                LastName = lastName;
                Department = department;
            }

            public override string ToString()
            {
                return $@"{Name} {LastName} {Department}";
            }
       
    }
}