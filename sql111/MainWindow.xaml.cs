using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MySql.Data.MySqlClient;

namespace sql111
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public bool _ifwindow1Closed;
        #region Construtor
        Window1 addOrUpdate;
        public MainWindow()
        {
            InitializeComponent();
            addOrUpdate = new Window1(this);
            _ifwindow1Closed = false;
            Display();
        }
        #endregion

        #region functions

        /// <summary>
        /// Basically is to let the DataGrid to have data showing
        /// Using MySqlConnection from <see cref="_ConnctionMySql"></see>
        /// </summary>
        public void Display()
        {
            try
            {
                MySqlConnection con = _ConnctionMySql._GetConnection();
                MySqlCommand cmd = new MySqlCommand("SELECT `emp_id`,`name`,`birth_date`,`sex`,`salary`,`branch_id`,`sup_id` FROM `test`", con);
                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds, "LoadDataBinding");

                _dataDisplay.DataContext = ds;
            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
        }


        #endregion


        #region Events
        private void _Search(object sender, TextChangedEventArgs e)
        {
            try
            {
                MySqlConnection con = _ConnctionMySql._GetConnection();
                MySqlCommand cmd = new MySqlCommand("SELECT `emp_id`,`name`,`birth_date`,`sex`,`salary`,`branch_id`,`sup_id` FROM `test` WHERE `name` LIKE '%" + _searchBox.Text + "%'", con);
                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds, "LoadDataBinding");
                _dataDisplay.DataContext = ds;
                con.Close();
            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void _newButton_Click(object sender, RoutedEventArgs e)
        {
            addOrUpdate._ClearTextbox();
            addOrUpdate._saveButton.Content = "Add";
            addOrUpdate._info.Content = "ADD NEW\nINFORMATION";
            addOrUpdate.ShowDialog();
            
        }

        private void _updatebtn_Click(object sender, RoutedEventArgs e)
        {
            DataRowView data = (DataRowView)((Button)e.Source).DataContext;
            addOrUpdate.id = data[0].ToString();
            addOrUpdate.name = data[1].ToString();
            addOrUpdate.birthdate = data[2].ToString();
            addOrUpdate.sex = data[3].ToString();
            addOrUpdate.salary = data[4].ToString();
            addOrUpdate.branchID = data[5].ToString();
            addOrUpdate.supID = data[6].ToString();
            addOrUpdate.Update();
            addOrUpdate.ShowDialog();

        }

        private void _deletebtn_Click1(object sender, RoutedEventArgs e)
        {
            DataRowView data = (DataRowView)((Button)e.Source).DataContext;
            if (MessageBox.Show("You are deleting an employee's information!\n are you sure?", "Warning", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
            {
                string _id = data[0].ToString();
                _ConnctionMySql._DeleteEmployee(_id);
                Display();
                return;
            }
            else
            {
                return;
            }

        }

        private void _mainWin_Closed(object sender, EventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
    #endregion
}
