using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinForms_DependencyService.Model;

namespace XamarinForms_DependencyService.ViewModel
{
    public class ProfilePageViewModel
    {
        private ProfileModel profileModelprop;
        public ProfileModel ProfileModelProp
        {
            get
            {
                return profileModelprop;
            }
            set
            {
                profileModelprop = value;
            }
        }

        public string UserName
        {
            get
            {
                return profileModelprop.UserName;
            }
            set
            {
                profileModelprop.UserName = value;
                MessagingCenter.Send(new MessageModel() { Data = ProfileModelProp.UserName }, "UserName");
                // With Parameter
                //MessagingCenter.Send(new MessageModel() { Data = ProfileModelProp.UserName }, "UserName", "Hello");
            }
        }

        public ProfilePageViewModel()
        {
            ProfileModelProp = new ProfileModel();
        }
    }
}
