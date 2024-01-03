
using EFCodeFirstCore.Contexts;
using EFCodeFirstCore.Models;

Console.WriteLine("Test");

EnterpriseDbContext context = new EnterpriseDbContext();

//context.Departments.Add(new Department { Name = "HR" });
//context.SaveChanges();

//context.Employees.Add(new Employee
//{
//    SSN = "12345678914237",
//    FullName = "Hassan Tawfik",
//    Age = 25,
//    DeptID = 1,
//});
//context.SaveChanges();

IEnumerable<Employee> employees = context.Employees.Where(E => E.Age > 0);
foreach (Employee employee in employees)
{
    Console.WriteLine(employee.FullName);
}

//IQueryable<Employee> employees = context.Employees.Where(E => E.Age > 0);
//foreach (Employee employee in employees)
//{
//    Console.WriteLine(employee.FullName);
//}