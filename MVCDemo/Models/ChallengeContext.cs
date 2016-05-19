using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Data.SqlTypes;
using Dapper;
using MVCDemo.Controllers;

namespace MVCDemo.Models
{
    public class ChallengeContext :DbContext
    {
        SqlConnection connection  = new SqlConnection(ConfigurationManager.ConnectionStrings["ChallengeContext"].ToString());

        public DbSet<Challenges> ChallengeMaster { get; set; }

        
        public IEnumerable<Challenges> GetOptions()           //fetch the tournament type details from the table
        {

                connection.Open();
                string query = "SELECT * from tblChallengesMaster";
                var result = connection.Query<Challenges>(query);
                connection.Close();
                return result;
        }


        public string GetDescriptionFromOption(int option)           //fetch the tournament type details from the table
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ChallengeContext"].ToString());
            Challenges ch = new Challenges();
            connection.Open();
            string query = "SELECT ChallengeDescription from tblChallengesMaster where ChallengeId = " + option;
            SqlCommand cmd = new SqlCommand(query,connection);
            string result = cmd.ExecuteScalar().ToString();
            ch.ChallengeDescription = result;
            connection.Close();
            return result;

        }

        public IEnumerable<Solutions> GetSolutions()           //fetch the tournament type details from the table
        {


            string query = "SELECT ChallengeDescription,Name,Department,Solution FROM tblChallengesMaster INNER JOIN tblChallengesSolutions ON tblChallengesMaster.ChallengeId = tblChallengesSolutions.ChallengeId and tblChallengesMaster.ChallengeId =" + ChallengesController.chalId;
            var result = connection.Query<Solutions>(query);
            connection.Close();
            return result;


        }





    }
}