using System;
using System.Collections.Generic;

namespace CIIT_SocialMedia.Models;

public partial class TblTechnology
{
    public int TechnologyId { get; set; }

    public string TechnologyName { get; set; } = null!;

    public int? Flag { get; set; }

    public DateTime? InsertedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public virtual ICollection<TblTopic> TblTopics { get; set; } = new List<TblTopic>();
}
