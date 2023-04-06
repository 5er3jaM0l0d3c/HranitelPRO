using System;
using System.Collections.Generic;

namespace Entities;

public partial class Worker
{
    public string? Fio { get; set; }

    public int? PodrasdelId { get; set; }

    public int? OtdelId { get; set; }

    public int Code { get; set; }

    public virtual Otdel? Otdel { get; set; }

    public virtual Podrasdel? Podrasdel { get; set; }

    public virtual ICollection<Visitor> Visitors { get; } = new List<Visitor>();
}
