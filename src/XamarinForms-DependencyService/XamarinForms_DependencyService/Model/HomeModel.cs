using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinForms_DependencyService.Model
{
    public class HomeModel: INotifyPropertyChanged
    {
        private string appName;
        private string userName;
        
        public string AppName
        {
            get
            {
                return appName;
            }
            set
            {
                appName = value;
                RaisPropertyChanged("AppName");
            }
        }

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
