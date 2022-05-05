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

        public bool InserireSubject1()
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

        public bool InserireSubject2()
        {
            var subject = new Subject
            {
                NameSubject = "informatica",
                Description = "diffcile",
                Crediti = 10,
                Hours = 30,
            };


            var persister = new HelpSecretary(connectionString);
            return persister.AddSubject(subject);

        }

        public bool InserireSubject3()
        {
            var subject = new Subject
            {
                NameSubject = "analisi",
                Description = "diffcile",
                Crediti = 10,
                Hours = 25,
            };


            var persister = new HelpSecretary(connectionString);
            return persister.AddSubject(subject);

        }

        public bool InserireSubject4()
        {
            var subject = new Subject
            {
                NameSubject = "sistemi",
                Description = "medio",
                Crediti = 6,
                Hours = 15,
            };


            var persister = new HelpSecretary(connectionString);
            return persister.AddSubject(subject);

        }

        public bool InserireSubject5()
        {
            var subject = new Subject
            {
                NameSubject = "algoritmi",
                Description = "diffcile",
                Crediti = 8,
                Hours = 20,
            };


            var persister = new HelpSecretary(connectionString);
            return persister.AddSubject(subject);

        }
    }
}