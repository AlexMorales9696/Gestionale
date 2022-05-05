using People;

namespace Secretary
{
    internal class handlerPerson
    {


        private readonly string connectionString = "Server=ACADEMYNETPD09\\SQLEXPRESS;Database=Gestionale;Trusted_Connection=True;";

        public bool InserisciUnaPersona1()
        {
            var person = new Person
            {
                Name = "giulio",
                Surname = "bianchi",
                Birthday = new DateTime(1992, 04, 1),
                Gender = "male",
                Address = "Via sempione"



            };
            var persister = new HelpSecretary(connectionString);
            return persister.AddPerson(person);

        }



        public bool InserisciUnaPersona2()
        {
            var person = new Person
            {
                Name = "gioacomo",
                Surname = "verdi",
                Birthday = new DateTime(1950, 04, 1),
                Gender = "male",
                Address = "Via dante"



            };
            var persister = new HelpSecretary(connectionString);
            return persister.AddPerson(person);

        }
        public bool InserisciUnaPersona3()
        {
            var person = new Person
            {
                Name = "Nicola",
                Surname = "Verdi",
                Birthday = new DateTime(1950, 4, 5),
                Gender = "Male",
                Address = "Via europa"



            };
            var persister = new HelpSecretary(connectionString);
            return persister.AddPerson(person);

        }

        public bool InserisciUnaPersona4()
        {
            var person = new Person
            {
                Name = "paolo",
                Surname = "rossi",
                Birthday = new DateTime(1996, 4, 1),
                Gender = "Male",
                Address = "Via livello"



            };
            var persister = new HelpSecretary(connectionString);
            return persister.AddPerson(person);

        }
        public bool InserisciUnaPersona5()
        {
            var person = new Person
            {
                Name = "diana",
                Surname = "rossi",
                Birthday = new DateTime(1993, 4, 1),
                Gender = "female",
                Address = "Via roma"



            };
            var persister = new HelpSecretary(connectionString);
            return persister.AddPerson(person);

        }
        public bool InserisciUnaPersona6()
        {
            var person = new Person
            {
                Name = "giada",
                Surname = "rossi",
                Birthday = new DateTime(1996, 3, 2),
                Gender = "female",
                Address = "Via livello"



            };
            var persister = new HelpSecretary(connectionString);
            return persister.AddPerson(person);

        }

        public void CancellaUnaPersona(int Id)
        {
            var persister = new HelpSecretary(connectionString);
            persister.DeletePerona(Id);
        }





    }
}
