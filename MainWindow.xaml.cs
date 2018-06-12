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

namespace U5_Math_Tutor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Random Numbers and signs
        Random random1 = new Random();
        int firstnumber;
        int secondnumber;
        int randomsign;

        //Set 4 mathematical signs for random
        string[] mathsigns = new string[4];
        

        public MainWindow()
        {
            mathsigns[0] = "+";
            mathsigns[1] = "-";
            mathsigns[2] = "/";
            mathsigns[3] = "*";

            InitializeComponent();

         Question();
        }
        public void Question()
        {
            // make a number 1-10 and a sign
            firstnumber = random1.Next(1, 11);
            secondnumber = random1.Next(1, 11);
            randomsign = random1.Next(0, 4);
            //formulate question
            string randomquestion = firstnumber.ToString() + "  " + mathsigns[randomsign] + "  " + secondnumber.ToString();
            Questionasked.Text = randomquestion;
        }


        public void CheckAnswer_Click(object sender, RoutedEventArgs e)
        {
            String Mathanswer;
            int MathanswerINT;

            // Check Math Signs
            if (mathsigns[randomsign] == "+")
            {
                MathanswerINT = firstnumber + secondnumber;
                Mathanswer = MathanswerINT.ToString();
                if (Answer.Text == Mathanswer)
                {
                    MessageBox.Show("Your Answer is right.");

                }
                else
                {
                    MessageBox.Show("WRONG");

                }

            }
            if (mathsigns[randomsign] == "-")
            {
                MathanswerINT = firstnumber - secondnumber;
                Mathanswer = MathanswerINT.ToString();
                if (Answer.Text == Mathanswer)
                {
                    MessageBox.Show("Your Answer is right.");


                }
                else
                {
                    MessageBox.Show("WRONG");
                }
            }
            if (mathsigns[randomsign] == "/")
            {
                MathanswerINT = firstnumber / secondnumber;
                Mathanswer = MathanswerINT.ToString();
                if (Answer.Text == Mathanswer)
                {
                    MessageBox.Show("Your Answer is right.");
                }
                else
                {
                    MessageBox.Show("WRONG");
                }

            }
            if (mathsigns[randomsign] == "*")
            {
                MathanswerINT = firstnumber * secondnumber;
                Mathanswer = MathanswerINT.ToString();
                if (Answer.Text == Mathanswer)
                {
                    MessageBox.Show("Your Answer is right.");


                }
                else
                {
                    MessageBox.Show("WRONG");
                }

            }
        


                }




            }

        }

