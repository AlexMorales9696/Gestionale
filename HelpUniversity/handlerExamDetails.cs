using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University;
using People;
using University;
using People;

namespace Secretary
{
    internal class handlerExamDetails
    {
        private readonly string connectionString = "Server=ACADEMYNETPD09\\SQLEXPRESS;Database=Gestionale;Trusted_Connection=True;";

        public bool aggiugniExamDetails()
        {
            var examdetails = new ExamDetails
            {
                Idexam = 2,
                IdStudent = 1,
            };


            var persister = new HelpSecretary(connectionString);
            return persister.AddExamDetails(examdetails);

        }
    }
}
