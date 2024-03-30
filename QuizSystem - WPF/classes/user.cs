using QuizSystem___WPF.windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizSystem___WPF.classes
{
    public class user 
    {

    }
    public class student : user
    {
        public string UserName = "Lanz";
        public string Password = "12345";

    }

    public class tutor : user
    {
        public string UserName = "kamal";
        public string Password = "1234";
    }

    public class examinor : user
    {
        public string UserName = "anurud";
        public string Password = "54321";
    }
}
