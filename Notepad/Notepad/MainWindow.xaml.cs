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
using Microsoft.Win32;
using System.IO;

namespace Notepad
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

        string currentFile;

        private void Open_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox.Text.Length > 0)
            {
                MessageBox.Show("Are you sure you want to open a new file?  You'll lose this one!", "(Go Save This One First!", MessageBoxButton.YesNo);
                OpenFileDialog ofd = new OpenFileDialog();
                Nullable<bool> userWantsToOpenFile = ofd.ShowDialog();
                if (userWantsToOpenFile == true)
                {
                    File.ReadAllText(ofd.FileName);
                    string newFile = ofd.FileName;
                    TextBox.Text = newFile;
                    currentFile = ofd.FileName;
                }
            }
            else /// AAAAAH I AM REPEATING CODE
            {
                OpenFileDialog ofd = new OpenFileDialog();
                Nullable<bool> userWantsToOpenFile = ofd.ShowDialog();
                if (userWantsToOpenFile == true)
                {
                    File.ReadAllText(ofd.FileName);
                    string newFile = ofd.FileName;
                    TextBox.Text = newFile;
                    currentFile = ofd.FileName;
                }
            }
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            if (File.Exists(currentFile))
            {
                SaveFileDialog sfd = new SaveFileDialog();
                Nullable<bool> userWantsToSaveFile = sfd.ShowDialog();

                if (userWantsToSaveFile == true)
                {
                    string SaveFile = TextBox.Text;
                    File.WriteAllText("", SaveFile);
                }
            }
        }
    }
}
