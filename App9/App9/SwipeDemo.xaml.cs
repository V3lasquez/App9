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
    public partial class SwipeDemo : ContentPage
    {
        public SwipeDemo()
        {
            InitializeComponent();
        }
        void OnSwiped(object sender, SwipedEventArgs e)
        {
            string direction = e.Direction.ToString();
            if (direction == "Right")
                ((BoxView)sender).Background = new SolidColorBrush(Color.Red);
            if (direction == "Left")
                ((BoxView)sender).Background = new SolidColorBrush(Color.Red);
            if (direction == "Up")
                ((BoxView)sender).Background = new SolidColorBrush(Color.Red);
            if (direction == "Down")
                ((BoxView)sender).Background = new SolidColorBrush(Color.Red);
            _label.Text = $"You swiped: {e.Direction.ToString()}";
        }
    }
}