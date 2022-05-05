using People;
using University;

namespace Secretary
{
    internal class handlerTeacher
    {
        private readonly string connectionString = "Server=ACADEMYNETPD09\\SQLEXPRESS;Database=Gestionale;Trusted_Connection=True;";

        public bool InserisciTeacher1()
        {
            var teacher = new Teacher
            {
                IdPerson= 3,
                MatricolaTeacher = "123",
                DataAssunzione = new DateTime(2022, 2, 1),
                



            };
            var persister = new HelpSecretary(connectionString);
            return persister.AddTeacher(teacher);

        }
        public bool InserisciTeacher2()
        {
            var teacher = new Teacher
            {
                IdPerson = 5,
                MatricolaTeacher = "12334",
                DataAssunzione = new DateTime(2022, 1, 1),




            };
            var persister = new HelpSecretary(connectionString);
            return persister.AddTeacher(teacher);

        }
    }
}
