namespace RedFileProject.Models
{
    public class Message
    {
        public int Id { get; set; }

        public DateTime MessageDate { get; set; }

        public bool IsNotArchived { get; set; }
    }
}
