using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Page_Navigation_App.View
{
    /// <summary>
    /// Interaction logic for Entry.xaml
    /// </summary>
    public partial class Entry : Window
    {
        private readonly System.Threading.Timer timer;
        private DonutSpinner donutSpinner;

        public Entry()
        {
            InitializeComponent();

            timer = new System.Threading.Timer(ShowNextWindow, null, Timeout.Infinite, Timeout.Infinite);

            donutSpinner = this.FindName("donutSpinnerControl") as DonutSpinner;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Hide the button
            var button = (Button)sender; // cast to access property of visibilty
            button.Visibility = Visibility.Hidden;
            donutSpinner.Visibility = Visibility.Visible;

            // Start the timer for 5 seconds
            timer.Change(TimeSpan.FromSeconds(5), Timeout.InfiniteTimeSpan);
        }

        private void ShowNextWindow(object state)
        {
            // Invoke the window transition on the UI thread
            Application.Current.Dispatcher.Invoke(() =>
            {
                // Hide the current window
                this.Hide();

                // Show the next window
                MainWindow x = new MainWindow();
                x.ShowDialog();
            });
        }

        private void CloseApp_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
