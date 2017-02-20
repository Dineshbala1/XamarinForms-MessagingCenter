using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinForms_DependencyService.Model
{
    public class ProfileModel : INotifyPropertyChanged
    {
        public string userName;

        public string UserName
        {
            get
            {
                return userName;
            }
            set
            {
                userName = value;
                RaisPropertyChanged("UserName");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
