using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace demo
{

    public class taskManager
    {
      
        //global connection string
        string connection = @"Data source = (localdb)\task_demo;Database=prog_tasks";

        //creating a method to test connection 
        public void test_connection()
        {
            /*SQLConnection - used to make connection with database
             * SQLCommand - used to run queries
             * AqlDataReader - used to read what is connected by the sql command and
             * show the user data
             * 
             */

            //connect to the database
            SqlConnection connect = new SqlConnection(connection);

            //try and catch any error will throw
            try
            {
                //open the connection and close the connection
                connect.Open();

                //put the database query and run it
                MessageBox.Show("connected..");

                //then close it after youre done
                connect.Close();

            }
            catch (Exception error)
            {
                //show message erroe
                MessageBox.Show(error.Message);

            }

        }//end of method

        //method to insert or store task
        public void insert_task(string name, string description, string dueDate, string status)
        {//start

            //create the connection index
            SqlConnection connect = new SqlConnection(connection);

            //you must use try and catch

            //make sure that the using is covered
            using (SqlConnection connects = new SqlConnection(connection))
            {
                //open the connection
                connects.Open();

                //do the query
                string query = $"insert into demo_tasks values('{name}','{description}','{dueDate}','{status}');";

                //then use sql command to run the query
                SqlCommand run_query = new SqlCommand(query, connects);

                //then run the query as a non-executequery
                run_query.ExecuteNonQuery();

                connects.Close();



            }//end of using

        }//end of method


       //method to auto load all the users tasks
       public void load_tasks(ListView view_task)
        {//start of load task method

            /*SQLConnection - used to make connection with database
            * SQLCommand - used to run queries
            * AqlDataReader - used to read what is connected by the sql command and
            * show the user data
            * 
            */

            //create an instance for the connection
            SqlConnection connects = new SqlConnection(connection);

            //open connection
            connects.Open();

            //temp variable to hold query
            string query = $"select * from demo_tasks";

            SqlCommand run_query = new SqlCommand (query, connects);

            //reading what the command found and show/display, using SqlDataReader
            SqlDataReader data_collect = run_query.ExecuteReader();

            //temp variable for boolean, to get the status for data found ornot found
            //not found is false and if found is true

            bool data_found = false;

            //use the while loop to get all the comments
            while (data_collect.Read())
            {//start of while loop

                //data found must be true
                data_found = true;

                //getting all the columns by their names
                string task_id = data_collect["task_id"].ToString();
                string task_name = data_collect["task_name"].ToString() ;
                string task_description = data_collect["task_description"].ToString () ;
                string task_dueDate = data_collect["task_dueDate"].ToString ();
                string task_status = data_collect["task_status"].ToString();
                
              //add the found tasks to the ListView
              view_task.Items.Add(task_id +""+ task_name+ " with "+ task_description + " due on "+ task_dueDate+" and is "+task_status);

            }//end of while loop

            //display error message
            if (!data_found)
            {//start of if
                //displaythe message in a listview
                view_task.Items.Add("no task found");
            }

            //close the connection
            connects.Close();

        }//end of load task method

        public void complete_task(int id)
        {
            using (SqlConnection connects = new SqlConnection(connection))
            {
                connects.Open();

                string query = "UPDATE demo_tasks SET task_status='Completed' WHERE task_id=@id";

                SqlCommand cmd = new SqlCommand(query, connects);
                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();
            }
        }

        public void delete_task(int id)
        {
            using (SqlConnection connects = new SqlConnection(connection))
            {
                connects.Open();

                string query = "DELETE FROM demo_tasks WHERE task_id=@id";

                SqlCommand cmd = new SqlCommand(query, connects);
                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();
            }
        }

        public void update_task(int id, string newTask)
        {
            using (SqlConnection connects = new SqlConnection(connection))
            {
                connects.Open();

                string query = "UPDATE demo_tasks SET task_name=@task WHERE task_id=@id";

                SqlCommand cmd = new SqlCommand(query, connects);

                cmd.Parameters.AddWithValue("@task", newTask);
                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();
            }
        }




    }

}
