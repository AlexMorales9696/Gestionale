
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

    }
}
