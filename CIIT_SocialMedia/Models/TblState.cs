using System;
using System.Collections.Generic;

namespace CIIT_SocialMedia.Models;

public partial class TblState
{
    public int StateId { get; set; }

    public string StateName { get; set; } = null!;

    public int? Flag { get; set; }

    public DateTime? InsertedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public virtual ICollection<TblCity> TblCities { get; set; } = new List<TblCity>();
}
