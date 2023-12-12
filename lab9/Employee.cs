public class Employee : IComparable<Employee>
{
    public string Name { get; set; }
    public int Age { get; set; }
    public double Salary { get; set; }

    public Employee(string name, int age, double salary)
    {
        Name = name;
        Age = age;
        Salary = salary;
    }

    public int CompareTo(Employee other)
    {
        return Age.CompareTo(other.Age);
    }
}

public class SalaryComparer : IComparer<Employee>
{
    public int Compare(Employee x, Employee y)
    {
        return x.Salary.CompareTo(y.Salary);
    }
}

public class EmployeeList : IEnumerable<Employee>
{
    private List<Employee> employees = new List<Employee>();

    public void AddEmployee(Employee employee)
    {
        employees.Add(employee);
    }

    public IEnumerator<Employee> GetEnumerator()
    {
        employees.Sort();
        return employees.GetEnumerator();
    }
}
