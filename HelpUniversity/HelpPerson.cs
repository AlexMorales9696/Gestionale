using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using People;

namespace HelpUniversity
{
    internal class HelpPerson
    {
        private readonly string 
        ConnectionString = "Server=.;Database=Gestionale;Trusted_Connection=True;";

    

    
        
    public HelpPerson(string connectionString)
    {
            ConnectionString = connectionString;
    }

    public bool Add(Person person)
    {
        var sql = @"
                   INSERT INTO [dbo].[Person]
            ([Name]
           ,[Surname]
           ,[BirthDay]
           ,[Gender]
           ,[Address])
        VALUES
           (<Name, nvarchar(100),>
           ,<Surname, nvarchar(100),>
           ,<BirthDay, datetime,>
           ,<Gender, nvarchar(100),>
           ,<Address, nvarchar(200),>)";


        using var connection = new SqlConnection(ConnectionString);
        connection.Open();

    }

}
}
