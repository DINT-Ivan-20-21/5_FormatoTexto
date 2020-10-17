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

namespace _5_FormatoTexto
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void negritaCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            formateadoTextBlock.FontWeight = FontWeights.Bold;
        }

        private void negritaCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            formateadoTextBlock.FontWeight = FontWeights.Normal;
        }

        private void cursivaCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            formateadoTextBlock.FontStyle = FontStyles.Italic;
        }

        private void cursivaCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            formateadoTextBlock.FontStyle = FontStyles.Normal;
        }

        private void colorButton_Checked(object sender, RoutedEventArgs e)
        {
            formateadoTextBlock.Foreground = (sender as RadioButton).Tag as SolidColorBrush;
        }

        private void entradaTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            formateadoTextBlock.Text = (sender as TextBox).Text;
        }
    }
}
