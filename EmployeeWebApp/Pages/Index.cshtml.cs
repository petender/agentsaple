using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using EmployeeWebApp.Models;

namespace EmployeeWebApp.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public List<Employee> Employees { get; set; } = new List<Employee>();

    public void OnGet()
    {
        Employees = new List<Employee>
        {
            new Employee { FirstName = "John", LastName = "Doe" },
            new Employee { FirstName = "Jane", LastName = "Smith" },
            new Employee { FirstName = "Michael", LastName = "Johnson" },
            new Employee { FirstName = "Sarah", LastName = "Williams" },
            new Employee { FirstName = "Robert", LastName = "Brown" }
        };
    }
}
