using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Chapter4
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public void ButtonStylesWithResourcesPage(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ButtonStylesWithResourcesPage());
        }

        public void CSSPage(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CSSPage());
        }

        public void CustomDarkThemePage(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CustomDarkThemePage());
        }

        public void DeviceStylePage(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DeviceStylePage());
        }

        public void DynamicResourcePage(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DynamicResourcePage());
        }

        public void ExplicitStylePage(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ExplicitStylePage());
        }

        public void ImplicitStylePage(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ImplicitStylePage());
        }

        public void LocalDesignPage(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LocalDesignPage());
        }

        public void OverridingStylesPage(object sender, EventArgs e)
        {
            Navigation.PushAsync(new OverridingStylesPage());
        }

        public void StaticResourcesPage(object sender, EventArgs e)
        {
            Navigation.PushAsync(new StaticResourcesPage());
        }

        public void StylesPage(object sender, EventArgs e)
        {
            Navigation.PushAsync(new StylesPage());
        }
    }
}
