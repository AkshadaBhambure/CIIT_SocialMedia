using System;
using System.Collections.Generic;

namespace CIIT_SocialMedia.Models;

public partial class TblExperience
{
    public int ExperienceId { get; set; }

    public int? UserId { get; set; }

    public int? DesignationId { get; set; }

    public string? CompanyName { get; set; }

    public DateOnly? JoiningDate { get; set; }

    public DateOnly? LeavingDate { get; set; }

    public string? EmploymentType { get; set; }

    public string? Description { get; set; }

    public int? Flag { get; set; }

    public DateTime? InsertedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public virtual TblDesignation? Designation { get; set; }

    public virtual TblUserDetail? User { get; set; }
}
