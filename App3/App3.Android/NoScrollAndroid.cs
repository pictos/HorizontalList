using App3.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ResolutionGroupName("PJ")]
[assembly: ExportEffect(typeof(NoScrollAndroid), "NoScroll")]

namespace App3.Droid
{
    public class NoScrollAndroid : PlatformEffect
    {
        protected override void OnAttached()
        {
            if (Control is null) return;

            Control.VerticalScrollBarEnabled = false;
        }

        protected override void OnDetached() { }
    }
}