using Android.App;
using Android.OS;
using Cirrious.MvvmCross.Droid.Views;

namespace MvvmCrossPageNaviSample.Android.Views
{
    [Activity(Label = "View for FirstViewModel")]
    public class MainPageView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.MainPageView);
        }
    }
}