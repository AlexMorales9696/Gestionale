

namespace People
{
    internal class Teacher : Person
    {
        public int IdTeacher;
        public int MatricolaTeacher;
        public DateTime DataAssunzione;

        public Teacher(int idperson, string name, string surname, DateTime birthday, string address,int idteacher,int matricolateacher, DateTime dataassunzione) : base( idperson,  name, surname, birthday, address)
        {
            IdTeacher = idteacher;
            MatricolaTeacher = matricolateacher;
            DataAssunzione = dataassunzione;
        }
    }
}
