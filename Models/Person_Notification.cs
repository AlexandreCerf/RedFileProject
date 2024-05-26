namespace RedFileProject.Models
{
    public class Person_Notification
    {
        public string PersonId { get; set; } = null!;

        public int NotificationId { get; set; }

        public DateTime? ReadDate { get; set; }

        public virtual Notification Notification { get; set; } = null!;

        public virtual Person Person { get; set; } = null!;
    }
}
