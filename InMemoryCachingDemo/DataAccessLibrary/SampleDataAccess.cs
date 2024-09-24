namespace DataAccessLibrary;

public class SampleDataAccess
{
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
}
