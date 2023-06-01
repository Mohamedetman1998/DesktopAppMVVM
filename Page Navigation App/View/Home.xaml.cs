using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Windows.Threading;

namespace Page_Navigation_App.View
{
    public partial class Home : UserControl
    {
        private string[] imagePaths = { "/Images/1.jpg", "/Images/2.jpg", "/Images/3.jpg","/Images/4.jpg", "/Images/5.jpg", "/Images/6.jpg", "/Images/7.jpg" };
        private int currentIndex = 0;
        private DispatcherTimer timer;

        public Home()
        {
            InitializeComponent();

            // Initialize the timer with the desired interval
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(2);
            timer.Tick += Timer_Tick;
            timer.Start();

            // Set the initial image
            SetNextImage();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            SetNextImage();
        }

        private void SetNextImage()
        {
            // Load the next image and update the source of the Image control
            string imagePath = imagePaths[currentIndex];
            BitmapImage bitmap = new BitmapImage(new Uri(imagePath, UriKind.Relative));
            SlideshowImage.Source = bitmap;

            // Increment the index or reset to the beginning
            currentIndex = (currentIndex + 1) % imagePaths.Length;
        }
    }
}
