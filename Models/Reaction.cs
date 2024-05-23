namespace RedFileProject.Models
{
    public class Reaction
    {
        public int ReactionId { get; set; }

        public string ReactionName { get; set; } = null!;

        public string? ReactionPicturePath { get; set; }

        public virtual ICollection<Message_Reaction_Person> Message_Reaction_Person { get; set; } = new List<Message_Reaction_Person>();
    }
}
