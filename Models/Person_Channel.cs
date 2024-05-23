namespace RedFileProject.Models
{
    public class Person_Channel
    {
        public int PersonId { get; set; }

        public int ChannelId { get; set; }

        public DateTime? SignInDate { get; set; }

        public virtual Channel Channel { get; set; } = null!;

        public virtual Person Person { get; set; } = null!;
    }
}
