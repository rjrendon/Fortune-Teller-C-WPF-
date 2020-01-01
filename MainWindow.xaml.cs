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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Fortune_Teller_wpf_Csharp
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
        int randomNum1, randomNum2, randomNum3, randomNum4, randomNum5;
        Random rnd = new Random();

       
     
           
        //array random string
        string[] forRandom = {"Good luck, success. This is an important card that suggests good fortune after difficulty.",
            "The card of wishes. A wish/dream fulfilled. Look to the card just preceding this one to determine what the querent desires.",
            "Someone whose interest in you is unreliable; someone with fickle affections for you. This card can indicate lovesickness.",
                "A sudden wave of good luck. Someone takes care of you, takes warm interest in you.",
                " A warm partnership or engagement. This is a very favorable card that indicates strength and support coming from a partner.",
                "A dark-haired or fiery youth. Popular youth who is good-hearted and playful. Can also indicate an admirer.",
                "Wealthy marriage or a sudden windfall.",
                "Financial aid or success.",
                "New friendships, alliances are made.",
                "Beware of dishonesty or deceit; avoid blind acceptance of others at this time.",
                "Illness, accident, bad luck. The querent is at his/her personal low.",
                "An argument concerning finances, or on the job. Generally expected to be resolved happily."
        };

        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            

            if (Btn1.Content == Btn1.Content)
            {
                randomNum1 = rnd.Next(1, 14);
                randomNum2 = rnd.Next(15, 39);
                randomNum3 = rnd.Next(41, 60);
                randomNum4 = rnd.Next(61, 130);
                randomNum5 = rnd.Next(130, 199);
                Btn1.Content = Convert.ToString(randomNum1);
                Btn2.Content = Convert.ToString(randomNum2);
                Btn3.Content = Convert.ToString(randomNum3);
                Btn4.Content = Convert.ToString(randomNum4);
                Btn5.Content = Convert.ToString(randomNum5);

              

                if (randomNum1.ToString() == (string)Btn1.Content)
                {
                   
                    Advice.Text = "Choose Number";


                   

                    var scaleAnimation = new DoubleAnimation(0, 1, TimeSpan.FromSeconds(1));
                    var btn1Scale = (ScaleTransform)Btn1.RenderTransform;
                    var btn2Scale = (ScaleTransform)Btn2.RenderTransform;
                    var btn3Scale = (ScaleTransform)Btn3.RenderTransform;
                    var btn4Scale = (ScaleTransform)Btn4.RenderTransform;
                    var btn5Scale = (ScaleTransform)Btn5.RenderTransform;

                    btn1Scale.BeginAnimation(ScaleTransform.ScaleXProperty, scaleAnimation);
                    btn2Scale.BeginAnimation(ScaleTransform.ScaleXProperty, scaleAnimation);
                    btn3Scale.BeginAnimation(ScaleTransform.ScaleXProperty, scaleAnimation);
                    btn4Scale.BeginAnimation(ScaleTransform.ScaleXProperty, scaleAnimation);
                    btn5Scale.BeginAnimation(ScaleTransform.ScaleXProperty, scaleAnimation);



                    Btn1.Click -= Btn1_Click;
                    Btn2.Click -= Btn2_Click;
                    Btn3.Click -= Btn3_Click;
                    Btn4.Click -= Btn4_Click;
                    Btn5.Click -= Btn5_Click;

                    
                }

            }
           

        }


        private void Btn1_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
           

            if (Advice.Text == "Choose Number")
            {
                string[] randomString = forRandom;
                Random r = new Random();
                Advice.Text = (randomString[r.Next(0, 12)].ToString());
               
            }
            Btn1.IsEnabled = false;
            Btn2.IsEnabled = false;
            Btn3.IsEnabled = false;
            Btn4.IsEnabled = false;
            Btn5.IsEnabled = false;         
        }

        private void Btn2_Click(object sender, RoutedEventArgs e)
        {
            if (Btn2.Content == Btn2.Content)
            {
                
                randomNum1 = rnd.Next(1, 14);
                randomNum2 = rnd.Next(15, 39);
                randomNum3 = rnd.Next(41, 60);
                randomNum4 = rnd.Next(61, 130);
                randomNum5 = rnd.Next(130, 199);
                Btn1.Content = Convert.ToString(randomNum1);
                Btn2.Content = Convert.ToString(randomNum2);
                Btn3.Content = Convert.ToString(randomNum3);
                Btn4.Content = Convert.ToString(randomNum4);
                Btn5.Content = Convert.ToString(randomNum5);
                if (randomNum2.ToString() == (string)Btn2.Content)
                {
                    Advice.Text = "Choose Number";
                  

                    var scaleAnimation = new DoubleAnimation(0, 1, TimeSpan.FromSeconds(1));
                    var btn1Scale = (ScaleTransform)Btn1.RenderTransform;
                    var btn2Scale = (ScaleTransform)Btn2.RenderTransform;
                    var btn3Scale = (ScaleTransform)Btn3.RenderTransform;
                    var btn4Scale = (ScaleTransform)Btn4.RenderTransform;
                    var btn5Scale = (ScaleTransform)Btn5.RenderTransform;

                    btn1Scale.BeginAnimation(ScaleTransform.ScaleXProperty, scaleAnimation);
                    btn2Scale.BeginAnimation(ScaleTransform.ScaleXProperty, scaleAnimation);
                    btn3Scale.BeginAnimation(ScaleTransform.ScaleXProperty, scaleAnimation);
                    btn4Scale.BeginAnimation(ScaleTransform.ScaleXProperty, scaleAnimation);
                    btn5Scale.BeginAnimation(ScaleTransform.ScaleXProperty, scaleAnimation);

                    Btn1.Click -= Btn1_Click;
                    Btn2.Click -= Btn2_Click;
                    Btn3.Click -= Btn3_Click;
                    Btn4.Click -= Btn4_Click;
                    Btn5.Click -= Btn5_Click;
                }

            }

        }
        private void  Btn2_MouseDoubleClick (object sender, MouseButtonEventArgs e) 
        {
            if (Advice.Text == "Choose Number")
            {
                string[] randomString = forRandom;
                Random r = new Random();
                Advice.Text = (randomString[r.Next(0, 12)].ToString());
            }
            Btn1.IsEnabled = false;
            Btn2.IsEnabled = false;
            Btn3.IsEnabled = false;
            Btn4.IsEnabled = false;
            Btn5.IsEnabled = false;



        }


        private void Btn3_Click(object sender, RoutedEventArgs e)
        {

            if (Btn3.Content == Btn3.Content)
            {
                randomNum1 = rnd.Next(1, 14);
                randomNum2 = rnd.Next(15, 39);
                randomNum3 = rnd.Next(41, 60);
                randomNum4 = rnd.Next(61, 130);
                randomNum5 = rnd.Next(130, 199);
                Btn1.Content = Convert.ToString(randomNum1);
                Btn2.Content = Convert.ToString(randomNum2);
                Btn3.Content = Convert.ToString(randomNum3);
                Btn4.Content = Convert.ToString(randomNum4);
                Btn5.Content = Convert.ToString(randomNum5);
            }
            if (randomNum3.ToString() == (string)Btn3.Content)
            {
                Advice.Text = "Choose Number";
                

                var scaleAnimation = new DoubleAnimation(0, 1, TimeSpan.FromSeconds(1));
                var btn1Scale = (ScaleTransform)Btn1.RenderTransform;
                var btn2Scale = (ScaleTransform)Btn2.RenderTransform;
                var btn3Scale = (ScaleTransform)Btn3.RenderTransform;
                var btn4Scale = (ScaleTransform)Btn4.RenderTransform;
                var btn5Scale = (ScaleTransform)Btn5.RenderTransform;

                btn1Scale.BeginAnimation(ScaleTransform.ScaleXProperty, scaleAnimation);
                btn2Scale.BeginAnimation(ScaleTransform.ScaleXProperty, scaleAnimation);
                btn3Scale.BeginAnimation(ScaleTransform.ScaleXProperty, scaleAnimation);
                btn4Scale.BeginAnimation(ScaleTransform.ScaleXProperty, scaleAnimation);
                btn5Scale.BeginAnimation(ScaleTransform.ScaleXProperty, scaleAnimation);

                Btn1.Click -= Btn1_Click;
                Btn2.Click -= Btn2_Click;
                Btn3.Click -= Btn3_Click;
                Btn4.Click -= Btn4_Click;
                Btn5.Click -= Btn5_Click;

            }
        }

      

        private void Btn3_PreviewMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (Advice.Text == "Choose Number")
            {
                string[] randomString = forRandom;
                Random r = new Random();
                Advice.Text = (randomString[r.Next(0, 12)].ToString());
            }
            Btn1.IsEnabled = false;
            Btn2.IsEnabled = false;
            Btn3.IsEnabled = false;
            Btn4.IsEnabled = false;
            Btn5.IsEnabled = false;
        }

        private void MediaElement_MediaEnded(object sender, RoutedEventArgs e)
        {
            MediaElemRed.Position = TimeSpan.FromMilliseconds(1);
            MediaElemGreen.Position = TimeSpan.FromMilliseconds(1);
            MediaElemBlue.Position = TimeSpan.FromMilliseconds(1);
            MediaElemPink.Position = TimeSpan.FromMilliseconds(1);
            MediaElemOrange.Position = TimeSpan.FromMilliseconds(1);
        }

      
        private void Advice_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            var rotateAnimation = new DoubleAnimation(0, 360, TimeSpan.FromSeconds(1));
            var rt = (RotateTransform)Advice.RenderTransform;
            rt.BeginAnimation(RotateTransform.AngleProperty, rotateAnimation);
        }

        private void Btn4_Click(object sender, RoutedEventArgs e)
        {
            if (Btn4.Content == Btn4.Content)
            {
                randomNum1 = rnd.Next(1, 14);
                randomNum2 = rnd.Next(15, 39);
                randomNum3 = rnd.Next(41, 60);
                randomNum4 = rnd.Next(61, 130);
                randomNum5 = rnd.Next(130, 199);
                Btn1.Content = Convert.ToString(randomNum1);
                Btn2.Content = Convert.ToString(randomNum2);
                Btn3.Content = Convert.ToString(randomNum3);
                Btn4.Content = Convert.ToString(randomNum4);
                Btn5.Content = Convert.ToString(randomNum5);
            }

           
            if (randomNum4.ToString() == (string)Btn4.Content)
            {
                Advice.Text = "Choose Number";
              


                var scaleAnimation = new DoubleAnimation(0, 1, TimeSpan.FromSeconds(1));
                var btn1Scale = (ScaleTransform)Btn1.RenderTransform;
                var btn2Scale = (ScaleTransform)Btn2.RenderTransform;
                var btn3Scale = (ScaleTransform)Btn3.RenderTransform;
                var btn4Scale = (ScaleTransform)Btn4.RenderTransform;
                var btn5Scale = (ScaleTransform)Btn5.RenderTransform;

                btn1Scale.BeginAnimation(ScaleTransform.ScaleXProperty, scaleAnimation);
                btn2Scale.BeginAnimation(ScaleTransform.ScaleXProperty, scaleAnimation);
                btn3Scale.BeginAnimation(ScaleTransform.ScaleXProperty, scaleAnimation);
                btn4Scale.BeginAnimation(ScaleTransform.ScaleXProperty, scaleAnimation);
                btn5Scale.BeginAnimation(ScaleTransform.ScaleXProperty, scaleAnimation);

                Btn1.Click -= Btn1_Click;
                Btn2.Click -= Btn2_Click;
                Btn3.Click -= Btn3_Click;
                Btn4.Click -= Btn4_Click;
                Btn5.Click -= Btn5_Click;
            }
        }
        private void Btn4_PreviewMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (Advice.Text == "Choose Number")
            {
                string[] randomString = forRandom;
                Random r = new Random();
                Advice.Text = (randomString[r.Next(0, 12)].ToString());
            }
            Btn1.IsEnabled = false;
            Btn2.IsEnabled = false;
            Btn3.IsEnabled = false;
            Btn4.IsEnabled = false;
            Btn5.IsEnabled = false;
        }


        private void Btn5_Click(object sender, RoutedEventArgs e)
        {
            if (Btn5.Content == Btn5.Content)
            {
                randomNum1 = rnd.Next(1, 14);
                randomNum2 = rnd.Next(15, 39);
                randomNum3 = rnd.Next(41, 60);
                randomNum4 = rnd.Next(61, 130);
                randomNum5 = rnd.Next(130, 199);
                Btn1.Content = Convert.ToString(randomNum1);
                Btn2.Content = Convert.ToString(randomNum2);
                Btn3.Content = Convert.ToString(randomNum3);
                Btn4.Content = Convert.ToString(randomNum4);
                Btn5.Content = Convert.ToString(randomNum5);
            }

            if (randomNum5.ToString() == (string)Btn5.Content)
            {
                Advice.Text = "Choose Number";

                var scaleAnimation = new DoubleAnimation(0, 1, TimeSpan.FromSeconds(1));
                var btn1Scale = (ScaleTransform)Btn1.RenderTransform;
                var btn2Scale = (ScaleTransform)Btn2.RenderTransform;
                var btn3Scale = (ScaleTransform)Btn3.RenderTransform;
                var btn4Scale = (ScaleTransform)Btn4.RenderTransform;
                var btn5Scale = (ScaleTransform)Btn5.RenderTransform;

                btn1Scale.BeginAnimation(ScaleTransform.ScaleXProperty, scaleAnimation);
                btn2Scale.BeginAnimation(ScaleTransform.ScaleXProperty, scaleAnimation);
                btn3Scale.BeginAnimation(ScaleTransform.ScaleXProperty, scaleAnimation);
                btn4Scale.BeginAnimation(ScaleTransform.ScaleXProperty, scaleAnimation);
                btn5Scale.BeginAnimation(ScaleTransform.ScaleXProperty, scaleAnimation);

                Btn1.Click -= Btn1_Click;
                Btn2.Click -= Btn2_Click;
                Btn3.Click -= Btn3_Click;
                Btn4.Click -= Btn4_Click;
                Btn5.Click -= Btn5_Click;
            }
        }
        private void Btn5_PreviewMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (Advice.Text == "Choose Number")
            {
                string[] randomString = forRandom;
                Random r = new Random();
                Advice.Text = (randomString[r.Next(0, 12)].ToString());
            }
            Btn1.IsEnabled = false;
            Btn2.IsEnabled = false;
            Btn3.IsEnabled = false;
            Btn4.IsEnabled = false;
            Btn5.IsEnabled = false;
        }

    }
    }

