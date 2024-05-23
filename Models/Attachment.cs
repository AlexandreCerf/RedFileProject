namespace RedFileProject.Models
{
    public class Attachment
    {
        public int AttachmentId { get; set; }

        public string Name { get; set; } = null!;

        public string? Path { get; set; }

        //------------------------------------------------------

        public int MessageId { get; set; }

        public virtual Message Message { get; set; } = null!;

    }
}
