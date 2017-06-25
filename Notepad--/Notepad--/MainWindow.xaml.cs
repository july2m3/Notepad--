/*Notepad --
 * A dark theme Window Notepad replacement
 * Basic functionality working. More features coming soon.
 */
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
using Microsoft.Win32; //for saveFileDialog and openFileDialog
using System.IO; //for file saving


namespace Notepad__
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

        private void fileMenuNew_Click(object sender, RoutedEventArgs e)
        {
            tbxNotepad.Text = "";
        }

        //from http://www.wpf-tutorial.com/dialogs/the-openfiledialog/
        private void fileMenuOpen_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openDlg = new OpenFileDialog();

            Nullable<bool> result = openDlg.ShowDialog();

            if (result == true)
            {
                tbxNotepad.Text = File.ReadAllText(openDlg.FileName);
                Title = openDlg.FileName + " :Notepad--";
            }

        }


        //from https://stackoverflow.com/questions/5622854/how-do-i-show-a-save-as-dialog-in-wpf
        private void fileMenuSave_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveDlg = new SaveFileDialog();
            saveDlg.FileName = "Document"; //default file name
            saveDlg.DefaultExt = ".txt"; //default extension

            Nullable<bool> result = saveDlg.ShowDialog();

            if(result == true)
            {
                string filename = saveDlg.FileName;
                File.WriteAllText(filename, tbxNotepad.Text);
                Title = saveDlg.FileName + " :Notepad--";
            }
        }

        private void fileMenuClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void editMenuFind_Click(object sender, RoutedEventArgs e)
        {

        }

        private void editMenuReplace_Click(object sender, RoutedEventArgs e)
        {

        }

        private void helpMenu_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hi, the idea is to create a dark theme Windows Notepad clone.\n I apologize for this white alert box");
        }

     
    }
}
