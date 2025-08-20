using System;
using System.Collections.Generic;

namespace CIIT_SocialMedia.Models;

public partial class TblSpecialization
{
    public int SpecializationId { get; set; }

    public string SpecializationName { get; set; } = null!;

    public int? QualificationId { get; set; }

    public int? Flag { get; set; }

    public DateTime? InsertedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public virtual TblQualification? Qualification { get; set; }

    public virtual ICollection<TblUserQualification> TblUserQualifications { get; set; } = new List<TblUserQualification>();
}
