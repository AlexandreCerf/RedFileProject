namespace RedFileProject.Models
{
    public class Notification
    {
        public int Id { get; set; }
        public string? Name { get; set; } 

        public string? Content { get; set; }

        public DateTime NotificationDate { get; set; }

        //------------------------------------------------------

        public int NotificationTypeId { get; set; }

        public virtual NotificationType NotificationType { get; set; } = null!;

        public virtual ICollection<Person_Notification> Person_Notification { get; set; } = new List<Person_Notification>();

    }
}
