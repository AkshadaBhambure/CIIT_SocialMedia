using System;
using System.Collections.Generic;

namespace CIIT_SocialMedia.Models;

public partial class TblLocation
{
    public int LocationId { get; set; }

    public string LocationName { get; set; } = null!;

    public int? CityId { get; set; }

    public int? Flag { get; set; }

    public DateTime? InsertedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public virtual TblCity? City { get; set; }

    public virtual ICollection<TblUserDetail> TblUserDetails { get; set; } = new List<TblUserDetail>();
}
