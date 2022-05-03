

namespace University
{
    internal class Exam
    {
        public int Idexam { get; set; }
        public int Idteacher { get; set; }
        public int Idsubject {get; set;}
        public DateTime DataExam { get; set; }

        public Exam(int idexam,int idteacher,int idsubject,DateTime dataexam)
        {
            Idexam = idexam;
            Idteacher=idteacher;
            Idsubject = idsubject;
            DataExam = dataexam;

        }
}
}