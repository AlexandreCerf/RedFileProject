namespace RedFileProject.Models
{
    public class ChannelPersonRole
    {
        public int ChannelPersonRoleId { get; set; }

        public string Name { get; set; } = null!;

        public virtual ICollection<ChannelPersonRole_Person_Channel> ChannelPersonRole_Person_Channel { get; set; } = new List<ChannelPersonRole_Person_Channel>();
    }
}
