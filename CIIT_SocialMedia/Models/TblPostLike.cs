using System;
using System.Collections.Generic;

namespace CIIT_SocialMedia.Models;

public partial class TblPostLike
{
    public int LikeId { get; set; }

    public int? LikesCount { get; set; }

    public int? PostId { get; set; }

    public virtual TblPost? Post { get; set; }
}
