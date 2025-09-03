using OtoMate.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OtoMate.Domain.Entities
{
    public class Post : BaseEntity
    {       
        public string Content { get; set; }
        public string? ImageUrl { get; set; }

        public PostStatus Status { get; set; }

        // Foreign Keys
        public Guid UserId { get; set; }
        public virtual User User { get; set; }

        public int? CategoryId { get; set; }
        public virtual Category Category { get; set; }

        // Navigation
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Like> Likes { get; set; }
    }
}
