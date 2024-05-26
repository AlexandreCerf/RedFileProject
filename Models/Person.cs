using Microsoft.AspNetCore.Identity;

namespace RedFileProject.Models
{
    public class Person : IdentityUser
    {
        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public DateTime? DateCreatePerson { get; set; }

        public string? ProfilPicturePath { get; set; }

        public string? Description { get; set; }


        //---------------------------------------------------

        public int PersonJobTitleId { get; set; }

        public int PersonStatusId { get; set; }

        public int PersonRoleId { get; set; }

        public virtual ICollection<ChannelPersonRole_Person_Channel> ChannelPersonRole_Person_Channel { get; set; } = new List<ChannelPersonRole_Person_Channel>();

        public virtual ICollection<Message> Messages { get; set; } = new List<Message>();

        public virtual ICollection<Message_Reaction_Person> Message_Reaction_Person { get; set; } = new List<Message_Reaction_Person>();

        public virtual PersonJobTitle PersonJobTitle { get; set; } = null!;

        public virtual PersonRole PersonRole { get; set; } = null!;

        public virtual PersonStatus PersonStatus { get; set; } = null!;

        public virtual ICollection<Person_Channel> Person_Channel { get; set; } = new List<Person_Channel>();

        public virtual ICollection<Person_Message> Person_Message { get; set; } = new List<Person_Message>();

        public virtual ICollection<Person_Notification> Person_Notification { get; set; } = new List<Person_Notification>();

        





    }
}
