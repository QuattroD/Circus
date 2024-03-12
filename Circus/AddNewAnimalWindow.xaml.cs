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
using System.Windows.Shapes;

namespace Circus
{
    /// <summary>
    /// Логика взаимодействия для AddNewAnimalWindow.xaml
    /// </summary>
    public partial class AddNewAnimalWindow : Window
    {
        public AddNewAnimalWindow()
        {
            InitializeComponent();
            var user = DBConnection.connection.User.Where(x => x.Role_ID == 3).ToList();
            foreach(var item in user)
            {
                TrainerComboBox.Items.Add(item.FirstName);
            }
            foreach (var item in DBConnection.connection.Gender.ToList())
            {
                GenderComboBox.Items.Add(item.Gender_Name);
            }
        }

        private void AddAnimal_Click(object sender, RoutedEventArgs e)
        {
            if (AnimalNameTextBox.Text != null && AgeTextBox.Text != null && HeightTextBox.Text != null && FoodTextBox.Text != null && CareTxtBox.Text != null && GenderComboBox.Text != null && TrainerComboBox.Text != null)
            {
                var gender = DBConnection.connection.Gender.Where(x => x.Gender_Name == GenderComboBox.Text).FirstOrDefault();
                var trainer = DBConnection.connection.User.Where(x => x.FirstName == TrainerComboBox.Text).FirstOrDefault();
                Animal animal = new Animal()
                {
                    Animal_Name = AnimalNameTextBox.Text,
                    Animal_Age = int.Parse(AgeTextBox.Text),
                    Animal_Height = Convert.ToDecimal(HeightTextBox.Text),
                    Recommend_Food = FoodTextBox.Text,
                    Care = CareTxtBox.Text,
                    Gender_ID = gender.Gender_ID,
                    User_ID= trainer.User_ID,
                };
                DBConnection.connection.Animal.Add(animal);
                DBConnection.connection.SaveChanges();
                AnimalNameTextBox.Text = null;
                AgeTextBox.Text = null;
                HeightTextBox.Text = null;
                FoodTextBox.Text = null;
                CareTxtBox.Text = null;
                GenderComboBox.Text = null;
                TrainerComboBox.Text = null;
                MessageBox.Show("Животное успешно добавлено!");
            }
            else
            {
                MessageBox.Show("Invalid Data");
            }
        }
    }
}
