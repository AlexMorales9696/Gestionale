using University;


namespace Secretary
{
    internal class handlerExam
    {
        private readonly string connectionString = "Server=ACADEMYNETPD09\\SQLEXPRESS;Database=Gestionale;Trusted_Connection=True;";

        public bool AggiugiExam1()
        {
            var exam = new Exam
            {
                 Idteacher=1,
                 DataExam= new DateTime(2022, 2, 17),
                 Idsubject=5,
            };


            var persister = new HelpSecretary(connectionString);
            return persister.AddExam(exam);

        }
        public bool AggiugiExam2()
        {
            var exam = new Exam
            {
                Idteacher = 2,
                DataExam = new DateTime(2022, 2, 25),
                Idsubject = 2,
            };


            var persister = new HelpSecretary(connectionString);
            return persister.AddExam(exam);

        }
        public bool AggiugiExam3()
        {
            var exam = new Exam
            {
                Idteacher = 1,
                DataExam = new DateTime(2022, 3, 1),
                Idsubject = 3,
            };


            var persister = new HelpSecretary(connectionString);
            return persister.AddExam(exam);

        }
        public bool AggiugiExam4()
        {
            var exam = new Exam
            {
                Idteacher = 2,
                DataExam = new DateTime(2022, 2, 1),
                Idsubject = 4,
            };


            var persister = new HelpSecretary(connectionString);
            return persister.AddExam(exam);

        }
        public bool AggiugiExam5()
        {
            var exam = new Exam
            {
                Idteacher = 2,
                DataExam = new DateTime(2022, 2, 1),
                Idsubject = 5,
            };


            var persister = new HelpSecretary(connectionString);
            return persister.AddExam(exam);

        }

    }
}
