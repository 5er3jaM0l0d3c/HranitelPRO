using System;
using System.Collections.Generic;

namespace Entities;

public partial class Group
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Visitor> Visitors { get; } = new List<Visitor>();
}
