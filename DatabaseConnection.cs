using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//have to use OleDb as this is 'what i got' at work. can easily upscale to Mysql or whatever
using System.Data.OleDb;

namespace LoginScreen___Game
{
    class DatabaseConnection
    {
        /*local variables to the class*/
        string sql_string;                          /*used to store the SQL to execute on the database*/
        string strCon;                              /*used to store the connection info*/
        OleDbDataAdapter ResultingDataSet;/*used to store the results of the dataset*/
                                  // System.Data.MySql.

        
        public string SQL
        {
            /*take the result and store it in the variable
             /*built in some anti-injection stuff too*/
            set
            {
                sql_string = value;
              
            }//endset
        }


        /*when i refer to this in my code it will take the result and store it in the variable*/
        public string connection_string
        {
            set { strCon = value; }
        }


        /*when i refer to this in my code it will take the result and store it in the variable*/
        public System.Data.DataSet GetConnection
        {
            get { return MyDataSet(); }
        }

        //this exists as a i need to have slightly different code for insertitem, done a redirect for security.
        public string InsertItem
        {
            get { return InsertItemCode(); }
        }

  


        /*this code uses the variables above i have set to establish the connection*/
        private System.Data.DataSet MyDataSet()
        {

            OleDbConnection con = new OleDbConnection(strCon);

            /*opening and closing connections quickly saves memory and is efficient programming*/
            /*this is the same for databases and files*/
            con.Open();
            ResultingDataSet = new OleDbDataAdapter(sql_string, con);


            /*this gets the data using the SQL that i have given it and puts it into a data set to be used in the main program*/
            System.Data.DataSet Data_Set = new System.Data.DataSet();

            ResultingDataSet.Fill(Data_Set, "table_1_data");
            con.Close();

            return Data_Set;
        }

        /*this code uses the variables above i have set to establish the connection*/
        private string InsertItemCode()
        {
            OleDbConnection con = new OleDbConnection(strCon);

            con.Open();
            try
            {
                OleDbCommand InsertCommand = new OleDbCommand(sql_string, con);
                int temp = InsertCommand.ExecuteNonQuery();
                return "Data inserted" + temp.ToString();
            }
            catch (OleDbException exp)
            {
                return exp.Message;
            }
            finally
            {
                con.Close();
            }


            return "";
        }
        }
}
