using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinForms_DependencyService.Model;

namespace XamarinForms_DependencyService.ViewModel
{
    public class HomePageViewModel : INotifyPropertyChanged
    {
        private HomeModel homeModelprop;

        public event PropertyChangedEventHandler PropertyChanged;

        public HomeModel HomeModelProp
        {
            get
            {
                return homeModelprop;
            }
            set
            {
                homeModelprop = value;
                RaisPropertyChanged("HomeModelProp");
            }
        }

        public HomePageViewModel()
        {
            HomeModelProp = new HomeModel();
            HomeModelProp.AppName = "Xamarin.Forms MessagingCenter Sample";

            MessagingCenter.Subscribe<MessageModel>(this, "UserName", (model) =>
            {
                HomeModelProp.UserName = model.Data;
                //MessagingCenter.Unsubscribe<MessageModel>(this,"UserName");
            });

            //With param
            //MessagingCenter.Subscribe<MessageModel, string>(this, "UserName", (model, args) =>
            //{
            //    HomeModelProp.UserName = model.Data;
            //});
        }

        private void RaisPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
