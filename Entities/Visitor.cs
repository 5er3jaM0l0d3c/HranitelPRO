using System;
using System.Collections.Generic;

namespace Entities;

public partial class Visitor
{
    public int Id { get; set; }

    public string? Fio { get; set; }

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public DateTime? BirthDate { get; set; }

    public string? Pasport { get; set; }

    public string? Login { get; set; }

    public string? Password { get; set; }

    public DateTime? Date { get; set; }

    public int? CodeWorker { get; set; }

    public int? GroupeId { get; set; }

    public virtual Worker? CodeWorkerNavigation { get; set; }

    public virtual Group? Groupe { get; set; }
}
