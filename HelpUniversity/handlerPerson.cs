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

       
        private readonly string connectionString = "Server=.;Database=Gestionale;Trusted_Connection=True;";
      
        public bool InserisciUnaPersona()
        {
            var person = new Person
            {
                Name = "Nicola",
                Surname = "Verdi",
                Birthday = new DateTime(1950, 4, 5),
                Gender = "Male",
                 Address = "Via Dante"


               
            };
            var persister = new HelpSecretary(connectionString);
            return persister.AddPerson(person);

        }
    }
}
