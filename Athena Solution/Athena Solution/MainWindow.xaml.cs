﻿using Athena_Solution.Pages;
using MaterialDesignThemes.Wpf;
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

namespace Athena_Solution
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

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnRestore_Click(object sender, RoutedEventArgs e)
        {
            if (WindowState == WindowState.Normal)
                WindowState = WindowState.Maximized;
            else
                WindowState = WindowState.Normal;
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void rdHome_Checked(object sender, RoutedEventArgs e)
        {            
            Home hm = new Home();
            MainPanel.Content = hm;
            
        }

        private void rdTeachers_Checked(object sender, RoutedEventArgs e)
        {
            Teachers prof = new Teachers();
            MainPanel.Content = prof;
        }

        private void rdCabinets_Checked(object sender, RoutedEventArgs e)
        {
            Cabinet cabinet = new Cabinet();
            MainPanel.Content = cabinet;
        }

        private void rdGroups_Checked(object sender, RoutedEventArgs e)
        {
            Groups group = new Groups();
            MainPanel.Content = group;
        }
    }
}
