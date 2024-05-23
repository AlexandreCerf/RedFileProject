namespace RedFileProject.Models
{
    public class PersonStatus
    {
        public int ID { get; set; }
        public string? Name { get; set; }

        //------------------------------------------------------

        public virtual ICollection<Person> Persons { get; set; } = new List<Person>();
    }
}
