using System;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Page_Navigation_App.Model.Snake
{
    public static class Images
    {
        public readonly static ImageSource Empty
            =LoadImage("Empty.Png");
        public readonly static ImageSource Body
         = LoadImage("Body.Png");
        public readonly static ImageSource Head
         = LoadImage("Head.Png");
        public readonly static ImageSource Food
         = LoadImage("Food.Png");
        public readonly static ImageSource DeadBody
         = LoadImage("DeadBody.Png");
        public readonly static ImageSource DeadHead
         = LoadImage("DeadHead.Png");
        private static ImageSource LoadImage(string filename)
        {
            return new BitmapImage(new Uri($"Images/{filename}", UriKind.Relative));
        }
    }
}
