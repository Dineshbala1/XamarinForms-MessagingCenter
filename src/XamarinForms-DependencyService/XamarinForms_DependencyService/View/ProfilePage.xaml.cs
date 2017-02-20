using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using XamarinForms_DependencyService.Model;
using XamarinForms_DependencyService.ViewModel;

namespace XamarinForms_DependencyService.Page
{
    public partial class ProfilePage : ContentPage
    {
        public ProfilePage()
        {
            InitializeComponent();
            closeButton.Clicked += CloseButton_Clicked;
        }

        private void CloseButton_Clicked(object sender, EventArgs e)
        {
            MessagingCenter.Send(new MessageModel() { Data = (BindingContext as ProfilePageViewModel).ProfileModelProp.UserName }, "UserName");
            App.Navigation.PopModalAsync(true);
        }
    }
}
