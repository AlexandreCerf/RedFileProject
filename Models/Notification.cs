﻿namespace RedFileProject.Models
{
    public class Notification
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Content { get; set; }

        public DateTime NotificationDate { get; set; }
    }
}
