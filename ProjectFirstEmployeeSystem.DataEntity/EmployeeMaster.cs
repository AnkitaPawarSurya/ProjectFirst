using System;
using System.Collections.Generic;

namespace ProjectFirstEmployeeSystem.DataEntity;

public partial class EmployeeMaster
{
    public int EmpId { get; set; }

    public string? Fname { get; set; }

    public string? Lname { get; set; }

    public string? Gender { get; set; }

    public int? Age { get; set; }

    public string? Email { get; set; }

    public string? ContactNo { get; set; }

    public DateTime? Dob { get; set; }

    public int? CityId { get; set; }

    public bool? IsActive { get; set; }
}
