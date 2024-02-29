using RestaurantApp.Entities;
using RestaurantApp.Repositories;

var employeeRepository = new GenericRepository<Employee, int>();
employeeRepository.Add(new Employee { FirstName = "Magda" });
employeeRepository.Add(new Employee { FirstName = "Jan" });
employeeRepository.Add(new Employee { FirstName = "Kot" });
employeeRepository.Save();

//Zacznij od "Ograniczenia typów generycznych