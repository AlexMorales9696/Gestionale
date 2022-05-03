☺using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    

    internal class ExamDetails : Exam
    {
        public int IdexamDetails;
        public int IdStudent;
        public ExamDetails(int idexam, int idteacher, int idsubject, DateTime dataexam,int idexamdetails,int idstudent) :base( idexam,idteacher, idsubject, dataexam)
        {
            IdexamDetails = idexamdetails;
            IdStudent = idstudent;
        }
            


    }
}
