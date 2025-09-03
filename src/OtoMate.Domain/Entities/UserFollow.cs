using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoMate.Domain.Entities
{
    public class UserFollow : BaseEntity
    {
        public Guid FollowerId { get; set; }  // Takip eden
        public virtual User Follower { get; set; }

        public Guid FollowingId { get; set; } // Takip edilen
        public virtual User Following { get; set; }
    }
}
