using System;
using System.Collections.Generic;

namespace CIIT_SocialMedia.Models;

public partial class TblPostComment
{
    public int CommentId { get; set; }

    public string? Comment { get; set; }

    public int? PostId { get; set; }

    public int? LikesCount { get; set; }

    public int? Flag { get; set; }

    public DateTime? InsertedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public virtual TblPost? Post { get; set; }

    public virtual ICollection<TblCommentReply> TblCommentReplies { get; set; } = new List<TblCommentReply>();
}
