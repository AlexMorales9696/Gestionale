namespace People
{
    public class Person 
    {
        public int IdPerson { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birthday { get; set; }
        public string Address { get; set; }

        public Person(int idperson,string name,string surname,DateTime birthday,string address)
        {
            IdPerson = idperson;
            Name = name;
            Surname = surname;
            Birthday = birthday;
            Address = address;


        }


    }
}