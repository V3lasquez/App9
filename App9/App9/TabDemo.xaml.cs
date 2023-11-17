using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App9
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TabDemo : ContentPage
    {
        int tapCount;
        readonly Label label;
        public TabDemo()
        {
            InitializeComponent();

            var image = new Image
            {
                Source = "tapped.jpg",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            var tapGestureRecognizer = new TapGestureRecognizer();
            tapGestureRecognizer.NumberOfTapsRequired = 2;
            tapGestureRecognizer.Tapped += OnTapGestureRecognizerTapped;
            image.GestureRecognizers.Add(tapGestureRecognizer);

            label = new Label
            {
                Text = "tap the photo!",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            Content = new StackLayout
            {
                Padding = new Thickness(20, 100),
                Children = { image, label }
            };
        }

        void OnTapGestureRecognizerTapped(object sender, EventArgs args)
        {
            tapCount++;
            var imageSender = (Image)sender;
            if (tapCount % 2 == 0)
            {
                imageSender.Source = "primero.jpg";
            }
            else
            {
                imageSender.Source = "segundo.jpg";
            }
        }
    }

}