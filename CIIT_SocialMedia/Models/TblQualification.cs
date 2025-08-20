using System;
using System.Collections.Generic;

namespace CIIT_SocialMedia.Models;

public partial class TblQualification
{
    public int QualificationId { get; set; }

    public string QualificationName { get; set; } = null!;

    public int? Flag { get; set; }

    public DateTime? InsertedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public virtual ICollection<TblSpecialization> TblSpecializations { get; set; } = new List<TblSpecialization>();
}
