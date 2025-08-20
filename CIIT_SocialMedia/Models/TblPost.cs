using System;
using System.Collections.Generic;

namespace CIIT_SocialMedia.Models;

public partial class TblPost
{
    public int PostId { get; set; }

    public string? PostName { get; set; }

    public int? UserId { get; set; }

    public string? Content { get; set; }

    public string? MediaUrl { get; set; }

    public string? Visibility { get; set; }

    public string? Location { get; set; }

    public int? Flag { get; set; }

    public DateTime? InsertedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public virtual ICollection<TblPostComment> TblPostComments { get; set; } = new List<TblPostComment>();

    public virtual ICollection<TblPostLike> TblPostLikes { get; set; } = new List<TblPostLike>();

    public virtual ICollection<TblPostShare> TblPostShares { get; set; } = new List<TblPostShare>();

    public virtual TblUserDetail? User { get; set; }
}
