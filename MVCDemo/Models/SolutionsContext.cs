using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Data.SqlTypes;
using Dapper;

namespace MVCDemo.Models
{
    public class SolutionsContext : DbContext
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ChallengeContext"].ToString());

        public DbSet<Solutions1> Solutions { get; set; }

        public int InsertSolution(Solutions1 sol)
        {
            SqlConnection con = null;
            string result1 = "Exception";
            //string result = "";
            //try
            //{
                connection.Open();
                SqlCommand cmd = new SqlCommand
                ("insert into dbo.tblChallengesSolutions(ChallengeId, Name, Department, Solution)values(1,'"+sol.user + "','"+sol.department+"','"+sol.solution+"')",connection);
                var result = cmd.ExecuteNonQuery();
                connection.Close();
                return result;
            //}
            //catch
            //{
                //return result1;
               //return IAsyncResult.;
            //}
            //finally
            //{
                //connection.Close();
            //}
        }



    }
}