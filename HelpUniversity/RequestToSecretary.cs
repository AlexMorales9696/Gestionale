
using System.Data.SqlClient;
using People;


namespace Secretary
{
    internal class RequestToSecretary
    {
        private readonly string ConnectionString = "Server=ACADEMYNETPD09\\SQLEXPRESS;Database=Gestionale;Trusted_Connection=True;";
        public IEnumerable<Person> GetPeople(string surname)
        {
            var sql = @"
             SELECT[Id]
      ,[Name]
      ,[Surname]
      ,[BirthDay]
      ,[Gender]
      ,[Address]
            FROM[dbo].[Person]
            where Surname=@Surname";

            using var connection = new SqlConnection(ConnectionString);
            connection.Open();
            using var command = new SqlCommand(sql,connection);
            command.Parameters.AddWithValue("@Surname", surname);
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                yield return new Person
                {
                    Birthday = Convert.ToDateTime(reader["Birthday"]),
                    Gender = reader["Gender"].ToString(),
                    IdPerson = Convert.ToInt32(reader["Id"]),
                    Name = reader["Name"].ToString(),
                    Surname = reader["Surname"].ToString(),
                    Address = reader["Address"].ToString(),

                };
            }

         }

        public IEnumerable<Teacher> GetTachers()
        {
            var sql = @"
             SELECT p.Id,p.Name,p.Surname,p.Birthday,p.Address,p.Gender,t.IdTeacher,t.Matricola,t.DataAssunzione
            FROM Teacher t
             JOIN Person p  ON t.IdPerson=p.Id ";
 

            using var connection = new SqlConnection(ConnectionString);
            connection.Open();
           using var command = new SqlCommand(sql, connection);
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                yield return new Teacher
                {
                    IdPerson = Convert.ToInt32(reader["Id"]),
                    Name = reader["Name"].ToString(),
                    Surname = reader["Surname"].ToString(),
                    Birthday = Convert.ToDateTime(reader["Birthday"]),
                    Gender = reader["Gender"].ToString(),
                    Address = reader["Address"].ToString(),


                    IdTeacher = Convert.ToInt32(reader["IdTeacher"]),
                    MatricolaTeacher = reader["Matricola"].ToString(),
                    DataAssunzione = Convert.ToDateTime(reader["DataAssunzione"])


                };
            }

        }

        public IEnumerable<Person> GetPeople()
        {
            var sql = @"
             SELECT p.Id,p.Name,p.Surname,p.Birthday,p.Address,p.Gender
            FROM Person p ";

            using var connection = new SqlConnection(ConnectionString);
            connection.Open();
            using var command = new SqlCommand(sql,connection);
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                yield return new Person
                {
                    IdPerson = Convert.ToInt32(reader["Id"]),
                    Name = reader["Name"].ToString(),
                    Surname = reader["Surname"].ToString(),
                    Birthday = Convert.ToDateTime(reader["Birthday"]),
                    Gender = reader["Gender"].ToString(),
                    Address = reader["Address"].ToString(),
                };
            }

        }

    }
}
