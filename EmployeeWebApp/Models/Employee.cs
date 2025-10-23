namespace EmployeeWebApp.Models;

public class Employee
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    
    public string TruncatedLastName => LastName.Length > 3 
        ? LastName.Substring(0, 3) 
        : LastName;
}
