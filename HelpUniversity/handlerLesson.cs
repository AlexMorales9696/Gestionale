using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University;
using People;


namespace Secretary
{
    internal class handlerLesson
    {

        private readonly string connectionString = "Server=ACADEMYNETPD09\\SQLEXPRESS;Database=Gestionale;Trusted_Connection=True;";

        public bool AggiugiLesson()
        {
            var lesson = new Lesson
            {
                IdTeacher = 2,
                IdSubject=1,
            };


            var persister = new HelpSecretary(connectionString);
            return persister.AddLesson(lesson);

        }
    }
}
