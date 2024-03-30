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
    /// Interaction logic for report.xaml
    /// </summary>
    public partial class report : Window
    {
        public report()
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

        private void buttonBack_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            loginWIndow loginWIndow = new loginWIndow();
            loginWIndow.Show();
        }

        private void okButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            selectSubjects selectSubjectWindow = new selectSubjects();
            selectSubjectWindow.Show();
        }
    }
}
