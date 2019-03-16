using Microsoft.Win32;
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

namespace EP
{
    /// <summary>
    /// Interaction logic for UControl.xaml
    /// </summary>
    public partial class UControl : Window
    {
        public double hScale = 0.5;
        public double vScale = 1;

        public UControl()
        {
            InitializeComponent();
            hScaleComboBox.SelectedIndex = 0;
            vScaleComboBox.SelectedIndex = 0;
        }

        private void BrowseButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();

            dlg.DefaultExt = ".txt";
            dlg.DefaultExt = ".xlsx";
            dlg.Filter = "(*.txt)|*.txt|*.xlsx|*.xlsx|All Files (*.*)|*.*";

            if (dlg.ShowDialog() == true)
            {
                string filename = dlg.FileName;
                FilePathTextBox.Text = filename;
            }
        }

        private void hScaleComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (hScaleComboBox.SelectedIndex)
            {
                case 0:
                    hScale = 0.5;
                    break;
                case 1:
                    hScale = 1;
                    break;
                case 2:
                    hScale = 2;
                    break;
                case 3:
                    hScale = 5;
                    break;
            }
        }

        private void vScaleComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (vScaleComboBox.SelectedIndex)
            {
                case 0:
                    vScale = 1;
                    break;
                case 1:
                    vScale = 2;
                    break;
                case 2:
                    vScale = 5;
                    break;
                case 3:
                    vScale = 10;
                    break;
            }
        }
    }
}
