using MyList = Windows.UI.Xaml.Controls;
using Xamarin.Forms;
using Xamarin.Forms.Platform.UWP;
using App3.UWP;

[assembly: ResolutionGroupName("PJ")]
[assembly: ExportEffect(typeof(NoScrollUWP), "NoScroll")]

namespace App3.UWP
{
    public class NoScrollUWP : PlatformEffect
    {
        protected override void OnAttached()
        {
            if(Control is MyList.ListView lv)
                MyList.ScrollViewer.SetVerticalScrollBarVisibility(lv, MyList.ScrollBarVisibility.Hidden);
            
        }

        protected override void OnDetached() { }
    }
}
