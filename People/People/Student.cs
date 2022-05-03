

namespace People
{
    internal class Student : Person 
    {
        public int IdStudent;
        public int Matricola;
        public DateTime DataIscrzione;

        public Student(int idperson, string name, string surname, DateTime birthday, string address,int idstudente,int matrcola,DateTime dataiscrizone) : base(idperson, name, surname,birthday,address)
        {
            IdStudent = idstudente;
            Matricola = matrcola;
            DataIscrzione = dataiscrizone;

        }
    }
}
