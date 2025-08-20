using System;
using System.Collections.Generic;

namespace CIIT_SocialMedia.Models;

public partial class TblUserDetail
{
    public int UserId { get; set; }

    public string UserFullName { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string MiddleName { get; set; } = null!;

    public string? UserTitle { get; set; }

    public string? Gender { get; set; }

    public string EmailId { get; set; } = null!;

    public string MobileNo { get; set; } = null!;

    public string WhatsAppNo { get; set; } = null!;

    public int? DesignationId { get; set; }

    public int? RoleId { get; set; }

    public int? TopicId { get; set; }

    public DateOnly? Dob { get; set; }

    public string? CurrentAddress { get; set; }

    public string? PermenantAddress { get; set; }

    public int? LocationId { get; set; }

    public string? Pincode { get; set; }

    public string? ProfilePhoto { get; set; }

    public int? Flag { get; set; }

    public DateTime? InsertedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public virtual TblDesignation? Designation { get; set; }

    public virtual TblLocation? Location { get; set; }

    public virtual TblRole? Role { get; set; }

    public virtual ICollection<TblExperience> TblExperiences { get; set; } = new List<TblExperience>();

    public virtual ICollection<TblPostShare> TblPostShareSharedToNavigations { get; set; } = new List<TblPostShare>();

    public virtual ICollection<TblPostShare> TblPostShareUsers { get; set; } = new List<TblPostShare>();

    public virtual ICollection<TblPost> TblPosts { get; set; } = new List<TblPost>();

    public virtual ICollection<TblUserQualification> TblUserQualifications { get; set; } = new List<TblUserQualification>();

    public virtual TblTopic? Topic { get; set; }
}
