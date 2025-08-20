using System;
using System.Collections.Generic;

namespace CIIT_SocialMedia.Models;

public partial class TblTopic
{
    public int TopicId { get; set; }

    public string TopicName { get; set; } = null!;

    public int? TechnologyId { get; set; }

    public int? Flag { get; set; }

    public DateTime? InsertedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public virtual ICollection<TblUserDetail> TblUserDetails { get; set; } = new List<TblUserDetail>();

    public virtual TblTechnology? Technology { get; set; }
}
