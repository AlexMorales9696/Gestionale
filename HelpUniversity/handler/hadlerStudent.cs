using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using People;

namespace Secretary
{
    internal class hadlerStudent
    {
        private readonly string connectionString = "Server=ACADEMYNETPD09\\SQLEXPRESS;Database=Gestionale;Trusted_Connection=True;";

        public bool InserisciStudent1()
        {
            var student = new Student
            {
                IdPerson = 3,
                MatricolaStudent = "12323",
                DataIscrizione = new DateTime(2018, 2, 1),




            };
            var persister = new HelpSecretary(connectionString);
            return persister.AddStudent(student);

        
    }
        public bool InserisciStudent2()
        {
            var student = new Student
            {
                IdPerson = 2,
                MatricolaStudent = "987",
                DataIscrizione = new DateTime(2017, 2, 1),




            };
            var persister = new HelpSecretary(connectionString);
            return persister.AddStudent(student);


        }

        public bool InserisciStudent3()
        {
            var student = new Student
            {
                IdPerson = 4,
                MatricolaStudent = "98712",
                DataIscrizione = new DateTime(2015, 2, 1),




            };
            var persister = new HelpSecretary(connectionString);
            return persister.AddStudent(student);


        }

        public bool InserisciStudent4()
        {
            var student = new Student
            {
                IdPerson = 5,
                MatricolaStudent = "98211",
                DataIscrizione = new DateTime(2022, 4, 1),




            };
            var persister = new HelpSecretary(connectionString);
            return persister.AddStudent(student);


        }

        public bool InserisciStudent5()
        {
            var student = new Student
            {
                IdPerson = 6,
                MatricolaStudent = "29372",
                DataIscrizione = new DateTime(2022, 9, 1),




            };
            var persister = new HelpSecretary(connectionString);
            return persister.AddStudent(student);


        }
    }
}