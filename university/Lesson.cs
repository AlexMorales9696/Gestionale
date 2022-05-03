
namespace University
{
    internal class Lesson
    {
        public int IdLesson { get; set;}
        public int IdTeacher { get; set;}
        public int IdSubject{ get; set;}
        
        public Lesson(int idlesson,int idteacher,int idsubject)
        {
            IdLesson = idlesson;
            IdTeacher = idteacher;
            IdSubject = idsubject;
        }

    }
}
