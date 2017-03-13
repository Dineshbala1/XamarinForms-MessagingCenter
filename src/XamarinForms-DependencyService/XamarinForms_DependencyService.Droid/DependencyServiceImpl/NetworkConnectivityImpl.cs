using Android.Content;
using Android.Net;
using XamarinForms_DependencyService.Interface;
using XamarinForms_DependencyService.Droid.DependencyServiceImpl;

[assembly:Xamarin.Forms.Dependency(typeof(NetworkConnectivityImpl))]
namespace XamarinForms_DependencyService.Droid.DependencyServiceImpl
{
    class NetworkConnectivityImpl : IConnectivity
    {
        public bool IsConnected()
        {
            var connectivityManager =
                (ConnectivityManager) Xamarin.Forms.Forms.Context.GetSystemService(Context.ConnectivityService);
            var networkAction = connectivityManager.ActiveNetworkInfo;
            return networkAction.IsConnected;
        }
    }
}