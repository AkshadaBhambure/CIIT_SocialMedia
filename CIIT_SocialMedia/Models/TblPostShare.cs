using System;
using System.Collections.Generic;

namespace CIIT_SocialMedia.Models;

public partial class TblPostShare
{
    public int PostShareId { get; set; }

    public string? Comment { get; set; }

    public int? PostId { get; set; }

    public int? UserId { get; set; }

    public int? SharedTo { get; set; }

    public string? SharedPlatform { get; set; }

    public DateTime? InsertedAt { get; set; }

    public virtual TblPost? Post { get; set; }

    public virtual TblUserDetail? SharedToNavigation { get; set; }

    public virtual TblUserDetail? User { get; set; }
}
