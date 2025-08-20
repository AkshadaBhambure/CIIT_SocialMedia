using System;
using System.Collections.Generic;

namespace CIIT_SocialMedia.Models;

public partial class TblDesignation
{
    public int DesignationId { get; set; }

    public string DesignationName { get; set; } = null!;

    public int? Flag { get; set; }

    public DateTime? InsertedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public virtual ICollection<TblExperience> TblExperiences { get; set; } = new List<TblExperience>();

    public virtual ICollection<TblUserDetail> TblUserDetails { get; set; } = new List<TblUserDetail>();
}
