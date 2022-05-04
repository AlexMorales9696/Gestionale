﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            command.Parameters.AddWithValue("@Id", 1);
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
            command.Parameters.AddWithValue("@IdPerson",teacher.IdPerson);
            command.Parameters.AddWithValue("@Matricola", teacher.MatricolaTeacher);
            command.Parameters.AddWithValue("@DataAssunzione", teacher .DataAssunzione);
            

            return command.ExecuteNonQuery() > 0;
        }
        /* public bool AddStudent(Student student)
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
             command.Parameters.AddWithValue("@IdPerson",student.IdPerson);
             command.Parameters.AddWithValue("@MatricolaStudent", student.MatricolaStudent);
             command.Parameters.AddWithValue("@@DataIscrizione", student.DataIscrizione);


             return command.ExecuteNonQuery() > 0;
         }*/

        public bool AddClass(Lesson lesson)
        {
            var sql = @"
                     INSERT INTO[dbo].[Lesson]
            ([IdTeacher]
           ,[IdSubject] )
           
           
        VALUES
           (@IdTeacher
           ,@IdSubject)";


            using var connection = new SqlConnection(ConnectionString);
            connection.Open();
            using var command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@IdPerson", lesson.IdTeacher);
            command.Parameters.AddWithValue("@Matricola", lesson.IdSubject);



            return command.ExecuteNonQuery() > 0;
        }


        public bool AddClass(UniClass class1)
        {
            var sql = @"
                     INSERT INTO[dbo].[Class]
            ([IdStudent]
           ,[IdLesson]
           ,[DataAssunzione])
           
        VALUES
           (@IdStudent
           ,@IdLesson )";
           

            using var connection = new SqlConnection(ConnectionString);
            connection.Open();
            using var command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@IdPerson", class1.IdStudent);
            command.Parameters.AddWithValue("@Matricola", class1.IdLess);
           


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
           (@IdStudent
           ,@IdLesson 
           ,@Credits
           ,@Hours])";

            using var connection = new SqlConnection(ConnectionString);
            connection.Open();
            using var command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@IdPerson",subject.IdStudent);
            command.Parameters.AddWithValue("@Matricola", subject.Name);
            command.Parameters.AddWithValue("@Matricola", subject.IdLess);
            command.Parameters.AddWithValue("@Matricola", subject.IdLess);




            return command.ExecuteNonQuery() > 0;
        }
    }
}
