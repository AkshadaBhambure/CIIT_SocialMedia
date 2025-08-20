using System;
using System.Collections.Generic;

namespace CIIT_SocialMedia.Models;

public partial class TblCity
{
    public int CityId { get; set; }

    public string CityName { get; set; } = null!;

    public int? StateId { get; set; }

    public int? Flag { get; set; }

    public DateTime? InsertedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public virtual TblState? State { get; set; }

    public virtual ICollection<TblLocation> TblLocations { get; set; } = new List<TblLocation>();
}
