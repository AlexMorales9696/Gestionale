using University;



namespace Secretary
{
    internal class handlerLesson
    {

        private readonly string connectionString = "Server=ACADEMYNETPD09\\SQLEXPRESS;Database=Gestionale;Trusted_Connection=True;";

        public bool AggiugiLesson1()
        {
            var lesson = new Lesson
            {
                IdTeacher = 2,
                IdSubject=1,
            };


            var persister = new HelpSecretary(connectionString);
            return persister.AddLesson(lesson);

        }
       
        public bool AggiugiLesson2()
        {
            var lesson = new Lesson
            {
                IdTeacher = 2,
                IdSubject = 2,
            };


            var persister = new HelpSecretary(connectionString);
            return persister.AddLesson(lesson);

        }
        public bool AggiugiLesson3()
        {
            var lesson = new Lesson
            {
                IdTeacher = 1,
                IdSubject = 3,
            };


            var persister = new HelpSecretary(connectionString);
            return persister.AddLesson(lesson);

        }
        public bool AggiugiLesson4()
        {
            var lesson = new Lesson
            {
                IdTeacher = 1,
                IdSubject = 5,
            };


            var persister = new HelpSecretary(connectionString);
            return persister.AddLesson(lesson);

        }
        public bool AggiugiLesson5()
        {
            var lesson = new Lesson
            {
                IdTeacher = 2,
                IdSubject = 4,
            };


            var persister = new HelpSecretary(connectionString);
            return persister.AddLesson(lesson);

        }
    }
}
