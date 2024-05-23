namespace RedFileProject.Models
{
    public class ChannelType
    {
        public int ChannelTypeId { get; set; }

        public string ChannelTypeName { get; set; } = null!;

        //----------------------------------------------------------------------------------

        public virtual ICollection<Channel> Channels { get; set; } = new List<Channel>();

    }
}
