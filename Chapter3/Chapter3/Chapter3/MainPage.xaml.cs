using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Chapter3
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public void AbsoluteLayoutExample(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AbsoluteLayoutExample());
        }

        public void ContentViewExample(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ContentViewExample());
        }

        public void GridExample2(object sender, EventArgs e)
        {
            Navigation.PushAsync(new GridExample2());
        }

        public void RelativeLayoutExample(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RelativeLayoutExample());
        }

        public void StackLayoutHorizontal(object sender, EventArgs e)
        {
            Navigation.PushAsync(new StackLayoutHorizontal());
        }

        public void SubContentView(object sender, EventArgs e)
        {
            //Navigation.PushAsync(new SubContentView());
        }
    }
}
