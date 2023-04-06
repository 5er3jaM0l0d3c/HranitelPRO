using System;
using System.Collections.Generic;

namespace Entities;

public partial class Podrasdel
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Worker> Workers { get; } = new List<Worker>();
}
