using System.Data.SqlClient;
using People;
using University;

namespace Secretary
{
    internal class HelpSecretary
    {
        private readonly string
        ConnectionString;
        public HelpSecretary(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public bool AddPerson(Person person)
        {
            var sql = @"
                   INSERT INTO [dbo].[Person]
            ([Name]
           ,[Surname]
           ,[BirthDay]
           ,[Gender]
           ,[Address])
        VALUES
           (@Name
           ,@Surname
           ,@BirthDay
           ,@Gender
           ,@Address)";


            using var connection = new SqlConnection(ConnectionString);
            connection.Open();
            using var command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@Name", person.Name);
            command.Parameters.AddWithValue("@Surname", person.Surname);
            command.Parameters.AddWithValue("@BirthDay", person.Birthday);
            command.Parameters.AddWithValue("@Gender", person.Gender);
            command.Parameters.AddWithValue("@Address", person.Address);

            return command.ExecuteNonQuery() > 0;
        }

        public bool DeletePerona(int idperson)

        {
            var sql = @"DELETE FROM [dbo].[Person]
                        WHERE Id=@Id ";
            using var connection = new SqlConnection(ConnectionString);
            connection.Open();
            using var command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@Id", idperson);
            return command.ExecuteNonQuery() > 0;
        }

        public bool AddTeacher(Teacher teacher)
        {
            var sql = @"
                    INSERT INTO[dbo].[Teacher]
            ([IdPerson]
           ,[Matricola]
           ,[DataAssunzione])
           
        VALUES
           (@IdPerson
           ,@Matricola
           ,@DataAssunzione)";


            using var connection = new SqlConnection(ConnectionString);
            connection.Open();
            using var command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@IdPerson", teacher.IdPerson);
            command.Parameters.AddWithValue("@Matricola", teacher.MatricolaTeacher);
            command.Parameters.AddWithValue("@DataAssunzione", teacher.DataAssunzione);


            return command.ExecuteNonQuery() > 0;
        }
        public bool AddStudent(Student student)
        {
            var sql = @"
                     INSERT INTO[dbo].[Student]
             ([IdPerson]
            ,[MatricolaStudent]
            ,[DataIscrizione])

         VALUES
            (@IdPerson
            ,@MatricolaStudent
            ,@DataIscrizione)";


            using var connection = new SqlConnection(ConnectionString);
            connection.Open();
            using var command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@IdPerson", student.IdPerson);
            command.Parameters.AddWithValue("@MatricolaStudent", student.MatricolaStudent);
            command.Parameters.AddWithValue("@DataIscrizione", student.DataIscrizione);


            return command.ExecuteNonQuery() > 0;
        }

        public bool AddLesson(Lesson lesson)
        {
            var sql = @"
                     INSERT INTO[dbo].[Lessons]
                    ([IdTeacher]
                    ,[IdSubject])
                    VALUES
                    (@IdTeacher
                    ,@IdSubject)";


            using var connection = new SqlConnection(ConnectionString);
            connection.Open();
            using var command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@IdTeacher", lesson.IdTeacher);
            command.Parameters.AddWithValue("@IdSubject", lesson.IdSubject);
            return command.ExecuteNonQuery() > 0;
        }


        public bool AddClass(UniClass uniClass)
        {
            var sql = @"
                     INSERT INTO[dbo].[Class]
            ([IdStudent]
            ,[IdLesson])
           
        VALUES
           (@IdStudent
           ,@IdLesson)";

            using var connection = new SqlConnection(ConnectionString);
            connection.Open();
            using var command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@IdStudent", uniClass.IdStudent);
            command.Parameters.AddWithValue("@IdLesson", uniClass.IdLess);
            return command.ExecuteNonQuery() > 0;
        }

        public bool AddSubject(Subject subject)
        {
            var sql = @"
                     INSERT INTO[dbo].[Subject]
            ([Name]
           ,[Description]
           ,[Credits]
           ,[Hours])
           
        VALUES
           (@Name
           ,@Description
           ,@Credits
           ,@Hours)";

            using var connection = new SqlConnection(ConnectionString);
            connection.Open();
            using var command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@Name", subject.NameSubject);
            command.Parameters.AddWithValue("@Description", subject.Description);
            command.Parameters.AddWithValue("@Credits", subject.Crediti);
            command.Parameters.AddWithValue("@Hours", subject.Hours);





            return command.ExecuteNonQuery() > 0;
        }

        public bool AddExam(Exam exam)
        {
            var sql = @"
                     INSERT INTO[dbo].[Exam]
            ([IdTeacher]
           ,[Date]
           ,[IdSubject])
           
           
        VALUES
           (@IdTeacher
           ,@Date
           ,@IdSubject)";


            using var connection = new SqlConnection(ConnectionString);
            connection.Open();
            using var command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@IdTeacher", exam.Idteacher);
            command.Parameters.AddWithValue("@Date", exam.DataExam);
            command.Parameters.AddWithValue("@IdSubject", exam.Idsubject);

            return command.ExecuteNonQuery() > 0;
        }

        public bool AddExamDetails(ExamDetails examdetails)
        {
            var sql = @"
                     INSERT INTO[dbo].[ExamDetails]
            ([IdExam]
            ,[IdStudent])
           
           
        VALUES
           (@IdExam
           ,@IdStudent)";


            using var connection = new SqlConnection(ConnectionString);
            connection.Open();
            using var command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@IdExam", examdetails.Idexam);
            command.Parameters.AddWithValue("@IdStudent", examdetails.IdStudent);

            return command.ExecuteNonQuery() > 0;
        }




    }
}
