namespace RedFileProject.Models
{
    public class Person_Message
    {
        public int PersonId { get; set; }

        public int MessageId { get; set; }

        public DateTime? ReadDate { get; set; }

        public bool? IsRead { get; set; }

        public virtual Message Message { get; set; } = null!;

        public virtual Person Person { get; set; } = null!;
    }
}
