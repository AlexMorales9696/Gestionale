using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University;
using People;

namespace Secretary
{
    internal class handlerExam
    {
        private readonly string connectionString = "Server=ACADEMYNETPD09\\SQLEXPRESS;Database=Gestionale;Trusted_Connection=True;";

        public bool AggiugiExam()
        {
            var exam = new Exam
            {
                 Idteacher=2,
                 DataExam= new DateTime(2022, 2, 1),
                 Idsubject=3,
            };


            var persister = new HelpSecretary(connectionString);
            return persister.AddExam(exam);

        }

    }
}
