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

namespace GAIManagment.ModuleLicenses.Presentation.Windows
{
    /// <summary>
    /// Логика взаимодействия для CategoryDialog.xaml
    /// </summary>
    public partial class CategoryDialog : Window
    {
        public CategoryDialog()
        {
            InitializeComponent();
        }

        public new string ShowDialog()
        {
            base.ShowDialog();

            return lvCategories.SelectedItem as String;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void ListView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Close();
        }
    }
}