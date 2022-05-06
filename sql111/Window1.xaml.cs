using System;
using System.Collections.Generic;
using System.Globalization;
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
using System.Windows.Shapes;

namespace sql111
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        private readonly MainWindow _parent;
        public string id, name, birthdate, sex, salary, branchID, supID;

        private void Win1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
            e.Cancel = true;
        }


        public Window1(MainWindow parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        public void Update()
        {
            DateTime result;
            try
            {
                result = DateTime.ParseExact(birthdate, "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
                
            }
            catch (Exception ex)
            {
                try
                {
                    result = DateTime.ParseExact(birthdate, "d/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
                }
                catch (Exception)
                {

                    try
                    {
                        result = DateTime.ParseExact(birthdate, "d/MM/yyyy hh:mm:ss", CultureInfo.InvariantCulture);
                    }
                    catch (Exception)
                    {
                        try
                        {
                            result = DateTime.ParseExact(birthdate, "d/M/yyyy hh:mm:ss", CultureInfo.InvariantCulture);
                        }
                        catch (Exception)
                        {
                            return;
                        }
                    }
                }
            }
            _ClearTextbox();
            _name.Text = name;
            _birthdate.Text = result.ToString("yyyy-MM-dd");
            _sex.Text = sex;
            _salary.Text = salary;
            _branchID.Text = branchID;
            _supID.Text = supID;
            _saveButton.Content = "Update";
            _info.Content = "Update\nInformation";


        }
        public void _ClearTextbox()
        {
            _name.Text = String.Empty;
            _birthdate.Text = String.Empty;
            _sex.Text = String.Empty;
            _salary.Text = String.Empty;
            _branchID.Text = String.Empty;
            _supID.Text = String.Empty;

        }

        private void _saveButton_Click(object sender, RoutedEventArgs e)
        {
            
            if (_name == null || _name.Text.Length < 1)
            {
                MessageBox.Show("The Name slot does not accomplish the requirements:\n  The textbox cannot be empty or less than 1 character", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);

            }
            if (_birthdate == null || _birthdate.Text.Length < 10)
            {
                MessageBox.Show("The Birth date slot does not accomplish the requirements:\n  Format: \n 'YYYY-MM-DD'", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);

            }
            if (_sex == null || _sex.Text.Length < 1 || _sex.Text.Length > 1)
            {
                MessageBox.Show("The Sex slot does not accomplish the requirements:\n  The textbox cannot be empty or less or greater than 1 character", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);

            }
            if (_salary == null || _salary.Text.Length < 3)
            {
                MessageBox.Show("The Salary does not accomplish the requirements:\n  The textbox cannot be empty or less than 3 number", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);

            }
            if (_branchID == null || _branchID.Text.Length > 1)
            {
                MessageBox.Show("The BranchID does not accomplish the requirements:\n  The textbox cannot be empty or greater or less than 1 number", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            if (_saveButton.Content.ToString() == "Add")
            {
                Employee emp = new Employee(_name.Text, _birthdate.Text, _sex.Text, _salary.Text, _branchID.Text, _supID.Text);
                _ConnctionMySql._AddEmployee(emp);
                _ClearTextbox();

            }
            else if (_saveButton.Content.ToString() == "Update")
            {
                Employee emp = new Employee(_name.Text, _birthdate.Text, _sex.Text, _salary.Text, _branchID.Text, _supID.Text);
                _ConnctionMySql._UpdateEmployee(emp, id);
                _ClearTextbox();
            }
            _parent.Display();
        }
    }
}
