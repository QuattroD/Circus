using System;
using System.Collections.Generic;
using System.Data.Entity;
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

namespace Circus
{
    /// <summary>
    /// Логика взаимодействия для AddNewUserWindow.xaml
    /// </summary>
    public partial class AddNewUserWindow : Window
    {
        public AddNewUserWindow()
        {
            InitializeComponent();     
            foreach (var item in DBConnection.connection.Role.ToList())
            {
                RoleComboBox.Items.Add(item.Role_Name);
            }
        }

        private void AddUser_Click(object sender, RoutedEventArgs e)
        {
            if(LoginTextBox.Text != null && PasswordBox.Password != null && FirstNameTextBox.Text != null && LastNameTextBox.Text != null && RoleComboBox.Text != null) 
            {
                var role = DBConnection.connection.Role.Where(x => x.Role_Name == RoleComboBox.Text).FirstOrDefault();
                User user = new User()
                {
                    Login = LoginTextBox.Text,
                    Password = PasswordBox.Password,
                    FirstName = FirstNameTextBox.Text,
                    LastName = LastNameTextBox.Text,
                    Role_ID = role.Role_ID
                };
                DBConnection.connection.User.Add(user);
                DBConnection.connection.SaveChanges();
                LoginTextBox.Text = null;
                PasswordBox.Password = null;
                FirstNameTextBox.Text = null;
                LastNameTextBox.Text = null;
                RoleComboBox.Text = null;
                MessageBox.Show("Пользователь успешно добавлен!");
            }
            else
            {
                MessageBox.Show("Invalid Data");
            }
        }
    }
}
