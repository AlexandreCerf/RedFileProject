namespace RedFileProject.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Password { get; set; }

        public string Mail { get; set; }

        public int PhoneNumber { get; set; }

        public string Name { get; set; }

        public DateTime CreationDate { get; set; }

        public string ProfileImage { get; set; }

        public string Description { get; set; }

        public string TokenReinitilizePassword { get; set; }

        public bool IsTemporaryPassword { get; set; }

        //---------------------------------------------------


        public UserJobTitle Id { get; set; }


    }
}
