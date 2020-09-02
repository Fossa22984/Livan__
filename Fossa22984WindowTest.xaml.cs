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

namespace NameOrYes
{
    /// <summary>
    /// Interaction logic for Fossa22984WindowTest.xaml
    /// </summary>
    public partial class Fossa22984WindowTest : Window
    {
        public Fossa22984WindowTest()
        {
            InitializeComponent();
        }

        private void PlayButton_Click(object sender, RoutedEventArgs e)
        {
            if (playButton1.Content.ToString() == "Play") { Media1.Play(); playButton1.Content = "Pause"; }
            else { Media1.Pause(); playButton1.Content = "Play"; }
        }
        private void StopButton_Click(object sender, RoutedEventArgs e)
        {
            playButton1.Content = "Play";
            Media1.Stop();
        }
        private void RestartButton_Click(object sender, RoutedEventArgs e)
        {
            Media1.Stop();
            Media1.Play();
        }


        private void PlayButton_Click_1(object sender, RoutedEventArgs e)
        {
            if (playButton2.Content.ToString() == "Play") { Media2.Play(); playButton2.Content = "Pause"; }
            else { Media2.Pause(); playButton2.Content = "Play"; }
        }
        private void StopButton_Click_1(object sender, RoutedEventArgs e)
        {
            playButton2.Content = "Play";
            Media2.Stop();
        }
        private void RestartButton_Click_1(object sender, RoutedEventArgs e)
        {
            Media2.Stop();
            Media2.Play();
        }

        private void PlayButton_Click_2(object sender, RoutedEventArgs e)
        {
            if (playButton3.Content.ToString() == "Play") { Media3.Play(); playButton3.Content = "Pause"; }
            else { Media3.Pause(); playButton3.Content = "Play"; }
        }
        private void StopButton_Click_2(object sender, RoutedEventArgs e)
        {
            playButton3.Content = "Play";
            Media3.Stop();
        }
        private void RestartButton_Click_2(object sender, RoutedEventArgs e)
        {
            Media3.Stop();
            Media3.Play();
        }

        private void PlayButton_Click_3(object sender, RoutedEventArgs e)
        {
            if (playButton4.Content.ToString() == "Play") { Media4.Play(); playButton4.Content = "Pause"; }
            else { Media4.Pause(); playButton4.Content = "Play"; }
        }
        private void StopButton_Click_3(object sender, RoutedEventArgs e)
        {
            playButton4.Content = "Play";
            Media4.Stop();
        }
        private void RestartButton_Click_3(object sender, RoutedEventArgs e)
        {
            Media4.Stop();
            Media4.Play();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var res = 0;
            if (answerFull1.IsChecked == true) res += 10;
            if (answerFull2.IsChecked == true) res += 10;
            if (answerFull3.IsChecked == true) res += 10;
            if (answerFull4.IsChecked == true) res += 10;
            if (answerFull5.IsChecked == true) res += 10;
            if (answerFull6.IsChecked == true) res += 10;
            if (answerFull7.IsChecked == true) res += 10;
            if (answerFull8.IsChecked == true) res += 10;

            if (mp3_1.Text == "LastChildFill" || mp3_1.Text == "LastChildFill=\"True\"") res += 10;
            if (mp3_2.Text == "Binding") res += 10;
            if (mp3_3.Text == "Drag-and-drop" || mp3_3.Text == "Drag and drop" || mp3_3.Text == "Drag_and_drop") res += 10;
            if (mp3_4.Text != "") res += 10;

            if (answer2_1.IsChecked == true) res += 5;
            if (answer2_2.IsChecked == true) res += 5;
            if (answer6_1.IsChecked == true) res += 5;
            if (answer6_2.IsChecked == true) res += 5;
            if (answer6_3.IsChecked == true) res += 5;
            if (answer7_1.IsChecked == true) res += 5;
            if (answer7_2.IsChecked == true) res += 5;
            if (answer7_3.IsChecked == true) res += 5;


            if (res < 64) MessageBox.Show($"Result --> {res}/100. Потрачено, не прошел!");
            else MessageBox.Show($"Result --> {res}/100");
        }
    }
}