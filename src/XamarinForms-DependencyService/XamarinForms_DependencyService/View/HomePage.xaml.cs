using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using XamarinForms_DependencyService.Model;
using XamarinForms_DependencyService.Page;
using XamarinForms_DependencyService.ViewModel;

namespace XamarinForms_DependencyService
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
            userNameButton.Clicked += UserNameButton_Clicked;
        }

        private void UserNameButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new ProfilePage());
        }
    }
}
