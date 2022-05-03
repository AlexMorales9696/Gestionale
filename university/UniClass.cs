namespace University
{
    public class UniClass
    {
        public int IdUniclass { get; set; }
        public int IdStudent { get; set; }
        public int IdLess{ get; set; }

        public UniClass(int iduniclass,int  idstudent,int idless)
        {
            IdUniclass = iduniclass;
            IdStudent = idstudent;
            IdLess = idless;

        }

    }
    
}