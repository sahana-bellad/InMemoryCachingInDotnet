using Microsoft.Extensions.Caching.Memory;

namespace DataAccessLibrary;

public class SampleDataAccess
{
    private readonly IMemoryCache _memoryCache;
    public SampleDataAccess(IMemoryCache memoryCache)
    {
        _memoryCache = memoryCache;
    }
    public List<EmployeeModel> GetEmployees()
    {
        List<EmployeeModel> employee = new();
        employee.Add(new() { FirstName = "John", LastName = "Doe" });
        employee.Add(new() { FirstName = "Jane", LastName = "Smith" });
        employee.Add(new() { FirstName = "Emily", LastName = "White" });
        employee.Add(new() { FirstName = "David", LastName = "Green" });
        Thread.Sleep(millisecondsTimeout: 3000);
        return employee;
    }

    public async Task<List<EmployeeModel>> GetEmployeesAsync()
    {
        List<EmployeeModel> employee = new();
        employee.Add(new() { FirstName = "John", LastName = "Doe" });
        employee.Add(new() { FirstName = "Jane", LastName = "Smith" });
        employee.Add(new() { FirstName = "Emily", LastName = "White" });
        employee.Add(new() { FirstName = "David", LastName = "Green" });
        await Task.Delay(millisecondsDelay: 3000);
        return employee;
    }

    public async Task<List<EmployeeModel>> GetEmployeesCache()
    {
        List<EmployeeModel> employee;
        employee = _memoryCache.Get<List<EmployeeModel>>(key: "employees");
        if (employee is null)
        {
            employee = new();
            employee.Add(new() { FirstName = "John", LastName = "Doe" });
            employee.Add(new() { FirstName = "Jane", LastName = "Smith" });
            employee.Add(new() { FirstName = "Emily", LastName = "White" });
            employee.Add(new() { FirstName = "David", LastName = "Green" });
            await Task.Delay(millisecondsDelay: 3000);
            _memoryCache.Set(key: "employees", employee, TimeSpan.FromMinutes(value: 1));
        }
        return employee;
    }
}