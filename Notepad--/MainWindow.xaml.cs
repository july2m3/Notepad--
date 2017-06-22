/*  Notepad-- a dark themed Win Notepad
 * A dark theme windows Notepad (please don't sue me microsoft :D)
 * The idea is that I like the Windows Notepad, it's quite nostalgic for me.
 * However, I hate applications with white background. I quite like the hackeresque, dark with green theme.
 * Last edit: July 22 2017
 *  July 22 2017: Made Notepad outline, and basic functionality
 * To Do:
 * Add a cursor at current position
 *  Open .txt file
 *  Save .txt file
 *      Have title of app change on file open, edit (unsaved), and saved
 *  Find ability
 *  Replace ability
 *  Add line numbers (and ability to take away line numbers)
 *  Add status bar
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

        private void fileBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void editBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void formatBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void helpBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("I tried to replicate the Windows Notepad applications." +
                "I wanted a dark theme version of Notepad to go along with my dark windows theme." +
                "I use Notepad as a way to quickly jot down some thoughts, as I like the minimalistic style." +
                "Sorry that the alert box breaks the theme. I'm currently working on that, as well as adding more functionalities." +
                "Like a proper file open and save options. "
                );

        }
    }
}
