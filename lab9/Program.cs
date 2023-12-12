Employee[] employees = new Employee[]
{
    new Employee("John", 30, 50000),
    new Employee("Alice", 25, 60000),
    new Employee("Bob", 35, 55000)
};

Array.Sort(employees);

foreach (var employee in employees)
{
    Console.WriteLine($"Name: {employee.Name}, Age: {employee.Age}");
}

Array.Sort(employees, new SalaryComparer());

Console.WriteLine("\nSorted by Salary:");
foreach (var employee in employees)
{
    Console.WriteLine($"Name: {employee.Name}, Salary: {employee.Salary:C}");
}




EmployeeList employeeList = new EmployeeList();
employeeList.AddEmployee(new Employee("John", 30, 50000));
employeeList.AddEmployee(new Employee("Alice", 25, 60000));
employeeList.AddEmployee(new Employee("Bob", 35, 55000));

foreach (var employee in employeeList)
{
    Console.WriteLine($"Name: {employee.Name}, Salary: {employee.Salary:C}");
}