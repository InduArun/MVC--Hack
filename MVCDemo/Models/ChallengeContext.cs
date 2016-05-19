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
    public class ChallengeContext :DbContext
    {
        SqlConnection connection  = new SqlConnection(ConfigurationManager.ConnectionStrings["ChallengeContext"].ToString());

        public DbSet<Challenges> ChallengeMaster { get; set; }

        
        public IEnumerable<Challenges> GetOptions()           //fetch the tournament type details from the table
        {
           

                string query = "SELECT * from tblChallengesMaster";
                var result = connection.Query<Challenges>(query);
                connection.Close();
                return result;
                
             

        }

        public DbSet<Solutions> SolutionsDetails { get; set; }


    }
}