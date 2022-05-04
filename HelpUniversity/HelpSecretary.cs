using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using People;

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
            command.Parameters.AddWithValue("@Gender", person.Birthday);
            command.Parameters.AddWithValue("@Address", person.Birthday);

            return command.ExecuteNonQuery() > 0;
        }

}
}
