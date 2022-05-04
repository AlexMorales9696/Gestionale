using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                Name = "paolo",
                Surname = "rossi",
                Birthday = new DateTime(1996, 3, 2),
                Gender = "Male",
                Address = "Via livello"



            };
            var persister = new HelpSecretary(connectionString);
            return persister.AddPerson(person);

        }

        public bool InserisciUnaPersona2()
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

        public bool InserisciUnaPersona3()
        {
            var person = new Person
            {
                Name = "giorgia",
                Surname = "verdi",
                Birthday = new DateTime(2001, 3, 1),
                Gender = "female",
                Address = "Via sempione"



            };
            var persister = new HelpSecretary(connectionString);
            return persister.AddPerson(person);

        }
        public bool InserisciUnaPersona4()
        {
            var person = new Person
            {
                Name = "giovanni",
                Surname = "piso",
                Birthday = new DateTime(1950, 4, 5),
                Gender = "Male",
                Address = "Via europa"



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
