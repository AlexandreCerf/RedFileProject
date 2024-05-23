using System;

namespace RedFileProject.Models
{
    public class Message
    {
        public int MessageId { get; set; }

        public string? Text { get; set; }

        public DateTime? DatePost { get; set; }

        public bool MessageIsNotArchived { get; set; }

        //--------------------------------------------------------------------------------------------------

        public int ChannelId { get; set; }

        public virtual Channel Channel { get; set; } = null!;

        public virtual Person Person { get; set; } = null!;

        public int PersonId { get; set; }

        public virtual ICollection<Attachment> Attachments { get; set; } = new List<Attachment>();

        public virtual ICollection<Message_Reaction_Person> Message_Reaction_Person { get; set; } = new List<Message_Reaction_Person>();

        public virtual ICollection<Person_Message> Person_Message { get; set; } = new List<Person_Message>();


    }
}
