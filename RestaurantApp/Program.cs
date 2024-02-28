using RestaurantApp.Entities;
using RestaurantApp.Repositories;

var employeeRepository = new EmployeeRepository();
employeeRepository.Add(new Employee { FirstName = "Magda" });
employeeRepository.Add(new Employee { FirstName = "Jan" });
employeeRepository.Add(new Employee { FirstName = "Kot" });
employeeRepository.Save();

//Zacznij od "Jak napisać generyczne repozytorium