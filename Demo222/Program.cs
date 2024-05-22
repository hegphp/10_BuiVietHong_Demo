// See https://aka.ms/new-console-template for more information
//Create new employee
using Demo22.Models;
using System.Text.Json;

Employee employee = new Employee();
employee.name = "John Doe";
employee.email = "johnDoe@gmail.com";
employee.salary = 1000;
var option = new JsonSerializerOptions { WriteIndented = true };
Console.WriteLine("*****Serialize*****");
string jsonData = JsonSerializer.Serialize(employee, option);
Console.WriteLine(jsonData);
Console.WriteLine("*****Deserialize*****");
Employee employee1 = JsonSerializer.Deserialize<Employee>(jsonData);
Console.WriteLine($"Name: {employee1.name}");
Console.WriteLine($"Email: {employee1.email}");
Console.WriteLine($"Salary: {employee1.salary}");


