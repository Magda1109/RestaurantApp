using RestaurantApp.Data;
using RestaurantApp.Entities;
using RestaurantApp.Repositories;


var employeeRepository = new SqlRepository<Employee>(new RestaurantAppDbContext());
var managerRepository = new SqlRepository<Manager>(new RestaurantAppDbContext());
var repository = new SqlRepository<Employee>(new RestaurantAppDbContext());

AddEmployees(employeeRepository);
AddManagers(managerRepository);
WriteAllToConsole(repository);

static void AddEmployees(IRepository<Employee> employeeRepository)
{
    employeeRepository.Add(new Employee { FirstName = "Magda" });
    employeeRepository.Add(new Employee { FirstName = "Jan" });
    employeeRepository.Add(new Employee { FirstName = "Kot" });
    employeeRepository.Save();
}

static void AddManagers(IRepository<Manager> managerRepository)
{
    managerRepository.Add(new Manager { FirstName = "Chris" });
    managerRepository.Add(new Manager { FirstName = "Alex" });
    managerRepository.Save();
}

static void WriteAllToConsole(IRepository<IEntity> repository)
{
    var items = repository.GetAll();
    foreach(var item in items)
    {
        Console.WriteLine(item);
    }
}

//Zacznij od "Kowariancja i kontrawariancja