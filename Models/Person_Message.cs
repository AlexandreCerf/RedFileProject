namespace RedFileProject.Models
{
    public class Person_Message
    {
        public string PersonId { get; set; } = null!;

        public int MessageId { get; set; }

        public DateTime? ReadDate { get; set; }

        //----------------------------------------------------------

        public virtual Message Message { get; set; } = null!;

        public virtual Person Person { get; set; } = null!;
    }
}
