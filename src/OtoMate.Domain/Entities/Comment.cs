using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoMate.Domain.Entities
{
    public class Comment : BaseEntity
    {
        public string Content { get; set; }

        // FK
        public Guid UserId { get; set; }
        public virtual User User { get; set; }

        public Guid PostId { get; set; }
        public Post Post { get; set; }

        
    }
}
