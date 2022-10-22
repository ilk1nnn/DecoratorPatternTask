using DecoratorPatternTask.Services;
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

namespace DecoratorPatternTask
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


        

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            IService service = new Service();
            Decorator2 decorator = new Decorator2(service);
            IService service2 = new Service();
            List<Media> medias = new List<Media>();
            if(facebookcheckbox.IsChecked == true)
            {
                IService facebook = new FacebookDecorator(service2);
                facebook.GetOneMedia(medias);
                foreach(Media media in medias)
                {
                    if (media.MediaName == "Facebook Service")
                    {
                        Uri imageUri = new Uri(media.ImagePath, UriKind.Relative);
                        BitmapImage imageBitmap = new BitmapImage(imageUri);
                        Image myImage = new Image();
                        facebooklbl.Content = media.MediaName;
                        facebookimg.Source = imageBitmap;
                    }
                }
            }
            if (instagramcheckbox.IsChecked == true)
            {
                IService instagram = new InstagramDecorator(service2);
                instagram.GetOneMedia(medias);
                foreach (Media media in medias)
                {
                    if (media.MediaName == "Instagram Service")
                    {
                        Uri imageUri = new Uri(media.ImagePath, UriKind.Relative);
                        BitmapImage imageBitmap = new BitmapImage(imageUri);
                        Image myImage = new Image();
                        instagramlbl.Content = media.MediaName;
                        instagramimg.Source = imageBitmap;
                    }
                }
            }
            if (twittercheckbox.IsChecked == true)
            {
                IService twitter = new TwitterDecorator(service2);
                twitter.GetOneMedia(medias);
                foreach (Media media in medias)
                {
                    if (media.MediaName == "Twitter Service")
                    {
                        Uri imageUri = new Uri(media.ImagePath, UriKind.Relative);
                        BitmapImage imageBitmap = new BitmapImage(imageUri);
                        Image myImage = new Image();
                        twitterlbl.Content = media.MediaName;
                        twitterimg.Source = imageBitmap;
                    }
                }
            }
            if (telegramcheckbox.IsChecked == true)
            {
                IService telegram = new TelegramDecorator(service2);
                telegram.GetOneMedia(medias);
                foreach (Media media in medias)
                {
                    if (media.MediaName == "Telegram Service")
                    {
                        Uri imageUri = new Uri(media.ImagePath, UriKind.Relative);
                        BitmapImage imageBitmap = new BitmapImage(imageUri);
                        Image myImage = new Image();
                        telegramlbl.Content = media.MediaName;
                        telegramimg.Source = imageBitmap;
                    }
                }
            }
            if (facebookcheckbox.IsChecked != true)
            {
                IService facebook = new FacebookDecorator(service2);
                facebook.GetOneMedia(medias);
                foreach (Media media in medias)
                {
                    if (media.MediaName == "Facebook Service")
                    {
                        Uri imageUri = new Uri(media.ImagePath, UriKind.Relative);
                        BitmapImage imageBitmap = new BitmapImage(imageUri);
                        Image myImage = new Image();
                        facebooklbl.Content = "";
                        facebookimg.Source = null;
                    }
                }
            }
            if (instagramcheckbox.IsChecked != true)
            {
                IService instagram = new InstagramDecorator(service2);
                instagram.GetOneMedia(medias);
                foreach (Media media in medias)
                {
                    if (media.MediaName == "Instagram Service")
                    {
                        Uri imageUri = new Uri(media.ImagePath, UriKind.Relative);
                        BitmapImage imageBitmap = new BitmapImage(imageUri);
                        Image myImage = new Image();
                        instagramlbl.Content = "";
                        instagramimg.Source = null;
                    }
                }
            }
            if (twittercheckbox.IsChecked != true)
            {
                IService twitter = new TwitterDecorator(service2);
                twitter.GetOneMedia(medias);
                foreach (Media media in medias)
                {
                    if (media.MediaName == "Twitter Service")
                    {
                        Uri imageUri = new Uri(media.ImagePath, UriKind.Relative);
                        BitmapImage imageBitmap = new BitmapImage(imageUri);
                        Image myImage = new Image();
                        twitterlbl.Content = "";
                        twitterimg.Source = null;
                    }
                }
            }
            if (telegramcheckbox.IsChecked != true)
            {
                IService telegram = new TelegramDecorator(service2);
                telegram.GetOneMedia(medias);
                foreach (Media media in medias)
                {
                    if (media.MediaName == "Telegram Service")
                    {
                        Uri imageUri = new Uri(media.ImagePath, UriKind.Relative);
                        BitmapImage imageBitmap = new BitmapImage(imageUri);
                        Image myImage = new Image();
                        telegramlbl.Content = "";
                        telegramimg.Source = null;
                    }
                }
            }

        }
    }
}
