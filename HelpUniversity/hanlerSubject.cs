using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University;
using People;
namespace Secretary
{
    internal class hanlerSubject
    {
        private readonly string connectionString = "Server=ACADEMYNETPD09\\SQLEXPRESS;Database=Gestionale;Trusted_Connection=True;";

        public bool InserireSubject()
        {
            var subject = new Subject
            {
                NameSubject = "matematica",
                Description = "difficile",
                Crediti = 9,
                Hours = 21,
            };
    

            var persister = new HelpSecretary(connectionString);
            return persister.AddSubject(subject); 
    
    }
}
}