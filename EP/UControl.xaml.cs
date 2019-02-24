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
        public UControl()
        {
            InitializeComponent();
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
    }
}
