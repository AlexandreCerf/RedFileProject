using System;

namespace RedFileProject.Models
{
    public class ChannelPersonRole_Person_Channel
    {
        public string PersonId { get; set; } = null!;

        public virtual Person Person { get; set; } = null!;

        public int ChannelId { get; set; }

        public virtual Channel Channel { get; set; } = null!;

        public DateTime? AffectDate { get; set; }

        public int ChannelPersonRoleId { get; set; }

        public virtual ChannelPersonRole ChannelPersonRole { get; set; } = null!;

        

    }
}
