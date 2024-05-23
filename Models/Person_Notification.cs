namespace RedFileProject.Models
{
    public class Person_Notification
    {
        public int PersonId { get; set; }

        public int NotificationId { get; set; }

        public DateTime? PersonXnotificationReadDate { get; set; }

        public virtual Notification Notification { get; set; } = null!;

        public virtual Person Person { get; set; } = null!;
    }
}
