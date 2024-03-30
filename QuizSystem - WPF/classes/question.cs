using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;
using System.Windows.Controls;
using System.Windows;
using System.Windows.Markup;

namespace QuizSystem___WPF.classes
{
    class question
    {
        public int correctAnswerICT;
        public int correctAnswerMaths;
        public int correctAnswerScience;
        public string hint;

        public void askQuestionICT(int questionNumber,TextBlock quiz,Button answer1,Button answer2,Button answer3,Button answer4)
        {

            switch (questionNumber)
            {
                case 1:
                    quiz.Text = "1. Is a Keyboard an_________ device?";

                    answer1.Content = "Input";
                    answer2.Content = "Output";
                    answer3.Content = "Both";
                    answer4.Content = "None of the above";

                    correctAnswerICT = 1;
                    
                    break;

                case 2:
                    quiz.Text = "2. What is a URL?";

                    answer1.Content = "Universal Remote Long";
                    answer2.Content = "Uniform Resource Locator";
                    answer3.Content = "Universal Resource Locator";
                    answer4.Content = "None of the above";

                    correctAnswerICT = 2;
                    break;

                case 3:
                    quiz.Text = "3. Which of these is a free operating system?";

                    answer1.Content = "Ubuntu";
                    answer2.Content = "Windows 7";
                    answer3.Content = "Windows Xp";
                    answer4.Content = "Mac OSX";

                    correctAnswerICT = 1;
                    break;
            }
        }
        public void askQuestionMaths(int questionNumber, TextBlock quiz, Button answer1, Button answer2, Button answer3, Button answer4)
        {

            switch (questionNumber)
            {
                case 1:
                    quiz.Text = "1. The average of first 50 natural numbers is ………… ?";

                    answer1.Content = "25.30";
                    answer2.Content = "25.5";
                    answer3.Content = "25.00";
                    answer4.Content = "None of the above";

                    correctAnswerMaths = 2;
                    break;

                case 2:
                    quiz.Text = "2. What is 1004 divided by 2 ?";

                    answer1.Content = "52";
                    answer2.Content = "5002";
                    answer3.Content = "502";
                    answer4.Content = "None of the above";

                    correctAnswerMaths = 3;
                    break;

                case 3:
                    quiz.Text = "3. The number of 3-digit numbers divisible by 6, is …………?";

                    answer1.Content = "149";
                    answer2.Content = "166";
                    answer3.Content = "150";
                    answer4.Content = "151";

                    correctAnswerMaths = 3;
                    break;

                case 4:
                    quiz.Text = "4. What is the next prime number after 5 ?";

                    answer1.Content = "6";
                    answer2.Content = "7";
                    answer3.Content = "9";
                    answer4.Content = "11";

                    correctAnswerMaths = 2;
                    break;

                case 5:
                    quiz.Text = "5. Solve: 300 – (150×2) ?";

                    answer1.Content = "150";
                    answer2.Content = "100";
                    answer3.Content = "50";
                    answer4.Content = "0";

                    correctAnswerMaths = 4;
                    break;
            }
        }

        public void askQuestionScience(int questionNumber, TextBlock quiz, Button answer1, Button answer2, Button answer3, Button answer4)
        {

            switch (questionNumber)
            {
                case 1:
                    quiz.Text = "1. Which among the following is largest animal Phylum?";

                    answer1.Content = "Mollusca";
                    answer2.Content = "Arthropoda";
                    answer3.Content = "Mammalia";
                    answer4.Content = "Annelida";

                    correctAnswerScience = 2;
                    hint = "1. It is said to be the largest phylum in the world." +
                        "\r\n2. It has more than 9,000 species." +
                        "\r\n3. They occur in almost all habitats around the world." +
                        "\r\n4. They are triploblastic and bilaterally symmetrical." +
                        "\r\n5. The body is enclosed in a thick and tough exoskeleton." +
                        "\r\n6. Sexes are separate ie there are both male and female individuals.";

                    break;

                case 2:
                    quiz.Text = "2. Bubo bubo is the scientific name of which of the following species?";

                    answer1.Content = "Hen";
                    answer2.Content = "Peacock";
                    answer3.Content = "Eagle";
                    answer4.Content = "Owl";

                    correctAnswerScience = 4;
                    hint = "Bubo bubo is the scientific name of owl." +
                        "The Bubo bubo or the Eurasian eagle-owl is a species of eagle-owl that resides in much of Eurasia.";
                    break;

                case 3:
                    quiz.Text = "3. Which among the following does not fall in the category of morbid fear or Phobia?";

                    answer1.Content = "Claustrophobia";
                    answer2.Content = "Photophobia";
                    answer3.Content = "Algophobia";
                    answer4.Content = "Anthophobia";

                    correctAnswerScience = 2;
                    hint = "Photophobia is not a fear. It is excessive sensitivity to light and the aversion to sunlight or well-lit places," +
                        "Claustrophobia is fear of confined places, Algophobia is fear of pain, Anthophobia is fear of flowers,";
                    break;

                case 4:
                    quiz.Text = "4. Urea is one of the major constituents of Urine in our body. In which among the following organs, Urea is formed?";

                    answer1.Content = "Kidneys";
                    answer2.Content = "Urinary Bladder";
                    answer3.Content = "Urethra";
                    answer4.Content = "Liver";

                    correctAnswerScience = 4;
                    hint = "1. The urea cycle is a cyclic mechanism that produces urea from ammonia, carbon dioxide, and aspartate." +
                        "\r\n2. The ornithine cycle, often known as the urea cycle, is a metabolic process that transforms highly poisonous ammonia to urea for excretion." +
                        "\r\n3. This cycle takes place mostly in an organism's liver. The synthesis of urea is accomplished through a series of five enzyme processes." +
                        "\r\n4. It mainly occurs in ureotelic organism.";
                    break;

                case 5:
                    quiz.Text = "5. The term Cyberknife is most closely associated with which among the following?";

                    answer1.Content = "Magnetic Resonance";
                    answer2.Content = "Cancer Surgery";
                    answer3.Content = "Software Security";
                    answer4.Content = "Remote sensing";

                    correctAnswerScience = 2;
                    hint = "The term Cyberknife is most closely associated with cancer surgery." +
                        "It is a radiation therapy device used to deliver radiosurgery for the " +
                        "treatment of benign tumors, malignant tumors and other medical conditions.";
                    break;
            }
        }
    }
}

