namespace Noordover.ResourceManagement.Domain
{
    public class Person
    {
        public int Id { get; set; }
        public string GivenName { get; set; }
        public string MiddleName { get; set; }
        public string SurName { get; set; }
        public PersonType Type { get; set; }
    }
}
