using QuizSystem___WPF.classes;
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

namespace QuizSystem___WPF.windows
{
    /// <summary>
    /// Interaction logic for loginWIndow.xaml
    /// </summary>
    public partial class loginWIndow : Window 
    {
        string username;
        string password;
        string USERNAME;
        string PASSWORD;
        public loginWIndow()
        {
            InitializeComponent();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void buttonMinimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void buttonClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void buttonLogin_Click(object sender, RoutedEventArgs e)
        {
            username = textUser.Text;
            password = textPassword.Password;
            student user = new student();

            USERNAME = user.UserName; 
            PASSWORD = user.Password;

            if (username.Equals(USERNAME) && password.Equals(PASSWORD))
            {
                this.Hide();
                selectSubjects subjectSelectionWindow = new selectSubjects();
                subjectSelectionWindow.Show();
                MessageBox.Show("Successfully logged as " + username);
            }
            else if (username != USERNAME && password.Equals(PASSWORD))
            {
                MessageBox.Show("Invalid username!");
            }
            else if (username.Equals(USERNAME) && password != PASSWORD)
            {
                MessageBox.Show("Wrong password!");
            }
            else if (username != USERNAME && password != PASSWORD)
            {
                MessageBox.Show("Wrong login details!");
            }
        }
    }
}
