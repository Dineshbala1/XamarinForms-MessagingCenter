using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;
using XamarinForms_DependencyService.Interface;

namespace XamarinForms_DependencyService.View
{
    public class NetworkConnectivityPage : ContentPage
    {
        public string IsConnected { get; set; }
        private Label label;
        public NetworkConnectivityPage()
        {
            BindingContext = this;
            label = new Label();
            label.Text = "Active Network Connection";
            var button = new Button();
            button.Clicked += Button_Clicked;
            button.Text = "Click to check network";
            var stacklayout = new StackLayout();
            stacklayout.Children.Add(label);
            stacklayout.Children.Add(button);
            Content = stacklayout;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            label.Text = DependencyService.Get<IConnectivity>().IsConnected()
                ? "Active Network Connection"
                : "No Active Internet";
        }
    }
}
