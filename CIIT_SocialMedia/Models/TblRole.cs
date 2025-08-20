using System;
using System.Collections.Generic;

namespace CIIT_SocialMedia.Models;

public partial class TblRole
{
    public int RoleId { get; set; }

    public string RoleName { get; set; } = null!;

    public int? Flag { get; set; }

    public DateTime? InsertedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public virtual ICollection<TblUserDetail> TblUserDetails { get; set; } = new List<TblUserDetail>();
}
