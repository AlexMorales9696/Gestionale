

namespace University
{
    internal class Subject
    {
        public int IdSubject { get; set; }
        public int IdStudent { get; set; }
        public int IdLesson { get; set; }

        public Subject(int idsubject, int idstudent, int idlesson)
        {
            IdSubject = idsubject;
            IdStudent = idstudent;
            IdLesson = idlesson;

        }
    }
}
