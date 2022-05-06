using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using MySql.Data.MySqlClient;

namespace sql111
{
    public class _ConnctionMySql
    {
        /// <summary>
        /// Get Connection with the DataBase
        /// </summary>
        /// <returns></returns>
        public static MySqlConnection _GetConnection()
        {
            //Here Enter the sever connection stuff
            string sql = "server=localhost;port=3306;userid=root;password=;database=";
            MySqlConnection con = new MySqlConnection(sql);

            try
            {
                con.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Connection Error!", ex.Message);

            }
            return con;
        }


        public static void _AddEmployee(Employee emp)
        {
            string _cmdLine = $"INSERT INTO `test` VALUES (null,'{emp._name}','{emp._birthdate}','{emp._sex}',{emp._salary},{emp._branchId.ToString()},{emp._supId.ToString()})";
            MySqlConnection con = _GetConnection();
            MySqlCommand cmd = new MySqlCommand(_cmdLine, con);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBoxResult a = MessageBox.Show("Employee was added successfully!", "Add New Profile",MessageBoxButton.OK , MessageBoxImage.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Operation Unsuccessful" + ex.Message,"Error!", MessageBoxButton.OK,MessageBoxImage.Warning);
            }
            con.Close();
        }
        public static void _UpdateEmployee(Employee emp,string id)
        {
            string _cmdLine = $"UPDATE `test` SET `name` = '{emp._name}',`birth_date` = '{emp._birthdate}', `sex` = '{emp._sex}', `salary` = {emp._salary},`branch_id` = {emp._branchId}, `sup_id` = {emp._supId} WHERE `emp_id` = {id}";
            MySqlConnection con = _GetConnection();
            MySqlCommand cmd = new MySqlCommand(_cmdLine, con);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBoxResult a = MessageBox.Show("Employee's Data was updated successfully!", "Add New Profile", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Operation Unsuccessful" + ex.Message, "Error!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            con.Close();
        }

        public static void _DeleteEmployee(string id)
        {
            string _cmdLine = $"DELETE FROM `test` WHERE `emp_id` = {id}";
            MySqlConnection con = _GetConnection();
            MySqlCommand cmd = new MySqlCommand(_cmdLine, con);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBoxResult a = MessageBox.Show("Employee's Data was deleted successfully!", "Add New Profile", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Operation Unsuccessful" + ex.Message, "Error!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            con.Close();
        }

        public static void _DisplayDataAndSearch(string q)
        {
            
        }
    }

}
