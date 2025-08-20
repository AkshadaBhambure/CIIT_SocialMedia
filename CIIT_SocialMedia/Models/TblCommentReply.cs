using System;
using System.Collections.Generic;

namespace CIIT_SocialMedia.Models;

public partial class TblCommentReply
{
    public int ReplyId { get; set; }

    public string? CommentReply { get; set; }

    public int? CommentId { get; set; }

    public int? LikesCount { get; set; }

    public int? Flag { get; set; }

    public DateTime? InsertedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public virtual TblPostComment? Comment { get; set; }
}
