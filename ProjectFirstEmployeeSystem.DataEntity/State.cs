using System;
using System.Collections.Generic;

namespace ProjectFirstEmployeeSystem.DataEntity;

public partial class State
{
    public int StateId { get; set; }

    public string? StateName { get; set; }

    public bool? IsActive { get; set; }

    public virtual ICollection<City> Cities { get; set; } = new List<City>();
}
