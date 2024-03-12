using System;
using System.Collections.Generic;
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

namespace Circus
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            var user = DBConnection.connection.User.Where(x => x.Login == UsernameTextBox.Text && x.Password == PasswordBox.Text).FirstOrDefault();
            if(user != null)
            {
                switch (user.User_ID)
                {
                    case 1:
                        AdminWindow admin = new AdminWindow();
                        this.Close();
                        admin.Show();
                        break;

                    case 2:
                        ArtistWindow artist = new ArtistWindow();
                        this.Close();
                        artist.Show();
                        break;

                    case 3:
                        TrainerWindow trainer = new TrainerWindow();
                        this.Close();
                        trainer.Show();
                        break;

                    case 4:
                        ServiceStaffWindow serviceStaff = new ServiceStaffWindow();
                        this.Close();
                        serviceStaff.Show();
                        break;
                }
            }
            else
            {
                MessageBox.Show("Invalid data");
            }
        }
    }
}
