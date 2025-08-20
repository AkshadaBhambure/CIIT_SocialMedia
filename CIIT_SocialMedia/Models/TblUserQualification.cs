using System;
using System.Collections.Generic;

namespace CIIT_SocialMedia.Models;

public partial class TblUserQualification
{
    public int UserQualificationId { get; set; }

    public int? UserId { get; set; }

    public int? SpecializationId { get; set; }

    public string? UniversityName { get; set; }

    public int? Flag { get; set; }

    public int? StartingYear { get; set; }

    public int? EndingYear { get; set; }

    public string? CourseType { get; set; }

    public double? Percentage { get; set; }

    public DateTime? InsertedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public virtual TblSpecialization? Specialization { get; set; }

    public virtual TblUserDetail? User { get; set; }
}
