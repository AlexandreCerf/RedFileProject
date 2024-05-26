namespace RedFileProject.Models
{
    public class Reaction
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public string? PicturePath { get; set; }

        public virtual ICollection<Message_Reaction_Person> Message_Reaction_Person { get; set; } = new List<Message_Reaction_Person>();
    }
}
