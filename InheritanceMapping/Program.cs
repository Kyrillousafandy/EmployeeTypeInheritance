using InheritanceMapping.Context;
using InheritanceMapping.Entities;

namespace InheritanceMapping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome my name is kyrillo");

            using EmployeeTypeDbContext dbContext = new EmployeeTypeDbContext();
            FullTime fullTime = new FullTime() { Name = "kyrillos", Address = "Cairo", Age = 29, Salary = 8000,StartDate = DateTime.Now};
            //PartTime partTime = new PartTime() { Name = "kyrillos", Address = "Cairo", Age = 29,CountOfHour = 120,HourRate = 500 };
            dbContext.FullTimeEmployees.Add(fullTime);
            //dbContext.PartTimeEmployees.Add(partTime);
            dbContext.SaveChanges();
        }
    }
}
