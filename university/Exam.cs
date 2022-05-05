namespace University
{
    public class Exam : ExamItem
    {
        public int Idteacher { get; set; }
        public int Idsubject { get; set; }
        public DateTime DataExam { get; set; }
    }
}