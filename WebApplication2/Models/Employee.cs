using System;
using System.Collections.Generic;

namespace WebApplication2.Models;

public partial class Employee
{
    public int EmployeeId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Position { get; set; }

    public string? Department { get; set; }

    public decimal? Salary { get; set; }

    public DateOnly? HireDate { get; set; }
}
