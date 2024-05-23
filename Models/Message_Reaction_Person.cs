using System;

namespace RedFileProject.Models
{
    public class Message_Reaction_Person
    {
        public int PersonId { get; set; }

        public int MessageId { get; set; }

        public int ReactionId { get; set; }

        public DateTime? Date { get; set; }
        
        //-------------------------------------------------------------

        public virtual Message Message { get; set; } = null!;

        public virtual Person Person { get; set; } = null!;

        public virtual Reaction Reaction { get; set; } = null!;
    }
}
