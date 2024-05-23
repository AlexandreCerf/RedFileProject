namespace RedFileProject.Models
{
    public class PersonJobTitle
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        //-----------------------------------------------------------------------------------

        public virtual ICollection<Person> Persons { get; set; } = new List<Person>();
    }
}
