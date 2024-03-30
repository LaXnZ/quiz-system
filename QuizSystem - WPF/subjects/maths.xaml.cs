using QuizSystem___WPF.classes;
using QuizSystem___WPF.windows;
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
using System.Xml.Linq;

namespace QuizSystem___WPF.subjects
{
    /// <summary>
    /// Interaction logic for maths.xaml
    /// </summary>
    public partial class maths : Window
    {
        report reportOut = new report();
        question quiz = new question();
        object sender;
        RoutedEventArgs e;
        int questionNumber = 1;
        int percentage;
        int score;
        int totalQuestions;
        student student = new student();
        string comment;
        public maths()
        {
            InitializeComponent();

            quiz.askQuestionMaths(questionNumber, textQuestion, answer1, answer2, answer3, answer4);
            totalQuestions = 5;
        }

        public void checkAnswer(object sender, RoutedEventArgs e)
        {

            var senderObject = (Button)sender;
            int buttonTag = Convert.ToInt32(senderObject.Tag);


            if (buttonTag == quiz.correctAnswerMaths)
            {
                score = score + 1;
            }

            if (score == 0)
            {
                comment = "Bad!";
            }
            else if (score > 0 && score < 3)
            {
                comment = "Good!";
            }
            else if (score > 3)
            {
                comment = "Very Good!";
            }

            if (questionNumber == totalQuestions)
            {
                percentage = (int)Math.Round((double)(score * 100) / totalQuestions);
                this.Hide();
                reportOut.Show();

                    reportOut.report_output.Text = "Quiz Ended!\n" +
                    student.UserName + " have answered " + score + " correctly.\n" +
                    "Your total percentage is " + percentage + "%\n" +
                    "Rate : " + comment + "\n" +
                    "Thank you for answering quiz!";

                score = 0;
                questionNumber = 0;
            }

            questionNumber++;
            quiz.askQuestionMaths(questionNumber, textQuestion, answer1, answer2, answer3, answer4);
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
            selectSubjects selectSubjectWindow = new selectSubjects();
            selectSubjectWindow.Show();
        }
    }
}
