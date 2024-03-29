﻿using System;
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
    /// Логика взаимодействия для AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        public AdminWindow()
        {
            InitializeComponent();
        }

        private void RegisterNewUser_Click(object sender, RoutedEventArgs e)
        {
            AddNewUserWindow addNewUserWindow = new AddNewUserWindow();
            addNewUserWindow.Show();
        }

        private void AddNewAnimal_Click(object sender, RoutedEventArgs e)
        {
            AddNewAnimalWindow addNewAnimalWindow = new AddNewAnimalWindow();
            addNewAnimalWindow.Show();
        }

        private void AddNewEnclosure_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ViewEmployeeProfiles_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AddModifyArtistSchedule_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AssignStaffTasks_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
