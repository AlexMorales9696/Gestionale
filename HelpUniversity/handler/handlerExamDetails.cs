using University;


namespace Secretary
{
    internal class handlerExamDetails
    {
        private readonly string connectionString = "Server=ACADEMYNETPD09\\SQLEXPRESS;Database=Gestionale;Trusted_Connection=True;";

        public bool aggiugniExamDetails1()
        {
            var examdetails = new ExamDetails
            {
                Idexam = 1,
                IdStudent = 2,
            };


            var persister = new HelpSecretary(connectionString);
            return persister.AddExamDetails(examdetails);

        }

        public bool aggiugniExamDetails2()
        {
            var examdetails = new ExamDetails
            {
                Idexam = 2,
                IdStudent = 4,
            };


            var persister = new HelpSecretary(connectionString);
            return persister.AddExamDetails(examdetails);

        }
        public bool aggiugniExamDetails3()
        {
            var examdetails = new ExamDetails
            {
                Idexam = 3,
                IdStudent = 5,
            };


            var persister = new HelpSecretary(connectionString);
            return persister.AddExamDetails(examdetails);

        }
        public bool aggiugniExamDetails4()
        {
            var examdetails = new ExamDetails
            {
                Idexam = 4,
                IdStudent = 2,
            };


            var persister = new HelpSecretary(connectionString);
            return persister.AddExamDetails(examdetails);

        }
        public bool aggiugniExamDetails5()
        {
            var examdetails = new ExamDetails
            {
                Idexam = 5,
                IdStudent = 1,
            };


            var persister = new HelpSecretary(connectionString);
            return persister.AddExamDetails(examdetails);

        }
    }
}
