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
using System.IO;

namespace lab_106_game_increase_score_01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string gameFile = "gamescores.txt";

        public MainWindow()
        {
            InitializeComponent();
            Start();
        }

        private void Start()
        {
            if (new FileInfo("gamescores.txt").Length == 0)
            {
                tb1.Text = "";
                tb2.Text = "";
                tb3.Text = "";
            }
            else
            {
                tb1.Text = File.ReadAllLines(gameFile)[0];
                tb2.Text = File.ReadAllLines(gameFile)[1];
                //tb3.Text = File.ReadAllLines(gameFile)[2];
                tb3.Text = File.ReadAllLines(gameFile)[-1];
            }
        }

        void Name(object sender, KeyEventArgs e)
        {
            TextBox tb = (sender as TextBox);
            if (e.Key == Key.Enter)
            {
                using (StreamWriter sw = File.AppendText(gameFile))
                {
                    sw.WriteLine(tb.Text);
                }


            }
        }
        void Level(object sender, KeyEventArgs e)
        {
            TextBox tb = (sender as TextBox);
            if (e.Key == Key.Enter)
            {
                using (StreamWriter sw = File.AppendText(gameFile))
                {
                    sw.WriteLine(tb.Text);
                }


            }
        }
        void EnterScore(object sender, KeyEventArgs e)
        {
            TextBox tb = (sender as TextBox);
            if (e.Key == Key.Enter)
            {
                using (StreamWriter sw = File.AppendText(gameFile))
                {
                    sw.WriteLine(tb.Text);
                }

                UpScore.Text = tb.Text;


            }
        }
       

        private void ButtonPlus(object sender, RoutedEventArgs e)
        {
            int num = Convert.ToInt32(UpScore.Text) + 1;
            UpScore.Text = num.ToString();
            using (StreamWriter sw = File.AppendText(gameFile))
            {
                sw.WriteLine(UpScore.Text);
            }
        }

        private void ButtonMinus(object sender, RoutedEventArgs e)
        {
            int num = Convert.ToInt32(UpScore.Text) - 1;
            UpScore.Text = num.ToString();
            using (StreamWriter sw = File.AppendText(gameFile))
            {
                sw.WriteLine( UpScore.Text);
            }
        }

        // Create a Gaming HOME PAGE
        // Name of gamer (saved to a text file)
        // Level reached
        // Top score
        // Prize for BEST PRESENTED INTERFACE

        // Next iteration : add up/down button to increase the score
    }
}
