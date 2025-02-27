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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFStudy
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            AboutUs window = new AboutUs();
            window.Show();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //Item item = new Item();
            //item.Id = "A001";
            //item.Name = "New York";
            //comboBox2.Items.Add(item);
            //item = new Item();
            //item.Id = "A002";
            //item.Name = "Los Angeles";
            //comboBox2.Items.Add(item);

            SignIn window = new SignIn();
            _ = window.ShowDialog();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (MessageBox.Show("Are you sure to exit?", "XOKR", MessageBoxButton.OKCancel, MessageBoxImage.Question, MessageBoxResult.Cancel) == MessageBoxResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void button_MouseEnter(object sender, MouseEventArgs e)
        {
            myPopup.IsOpen = true;
        }

        private void button_MouseLeave(object sender, MouseEventArgs e)
        {
            myPopup.IsOpen = false;
        }
    }
}
