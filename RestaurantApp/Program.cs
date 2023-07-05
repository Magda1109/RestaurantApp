using Microsoft.VisualBasic;
using RestaurantApp.Entities;
using RestaurantApp.Repositories;

var employeeRepository = new GenericRepository<Employee>();
employeeRepository.Add(new Employee { FirstName = "Adam"});
employeeRepository.Add(new Employee { FirstName = "Magda" });
employeeRepository.Add(new Employee { FirstName = "Jan" });
employeeRepository.Save();