namespace RedFileProject.Models
{
    public class Channel
    {
        public int ChannelId { get; set; }
        public string Name { get; set; } = null!;
        public string? ChannelImage { get; set; }

        //------------------------------------------------------

        public virtual ICollection<ChannelPersonRole_Person_Channel> ChannelPersonRole_Person_Channel { get; set; } = new List<ChannelPersonRole_Person_Channel>();

        public virtual ICollection<Message> Messages { get; set; } = new List<Message>();

        public virtual ICollection<Person_Channel> Person_Channel { get; set; } = new List<Person_Channel>();
    }
}
