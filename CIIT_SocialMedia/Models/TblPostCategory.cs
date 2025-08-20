using System;
using System.Collections.Generic;

namespace CIIT_SocialMedia.Models;

public partial class TblPostCategory
{
    public int PostCategoryId { get; set; }

    public string PostCategoryName { get; set; } = null!;

    public int? Flag { get; set; }

    public DateTime? InsertedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }
}
