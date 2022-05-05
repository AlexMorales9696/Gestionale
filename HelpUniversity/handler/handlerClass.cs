using University;

namespace Secretary
{
    internal class handlerClass
    {
        private readonly string connectionString = "Server=ACADEMYNETPD09\\SQLEXPRESS;Database=Gestionale;Trusted_Connection=True;";

        public bool AggiugiClass1()
        {
            var class1 = new UniClass
            {
                IdStudent=1,
                IdLess=2,
            };


            var persister = new HelpSecretary(connectionString);
            return persister.AddClass(class1);

        }

        public bool AggiugiClass2()
        {
            var class1 = new UniClass
            {
                IdStudent = 2,
                IdLess = 4,
            };


            var persister = new HelpSecretary(connectionString);
            return persister.AddClass(class1);

        }
        public bool AggiugiClass3()
        {
            var class1 = new UniClass
            {
                IdStudent = 3,
                IdLess = 5,
            };


            var persister = new HelpSecretary(connectionString);
            return persister.AddClass(class1);

        }
        public bool AggiugiClass4()
        {
            var class1 = new UniClass
            {
                IdStudent = 4,
                IdLess = 6,
            };


            var persister = new HelpSecretary(connectionString);
            return persister.AddClass(class1);

        }
    }
}
