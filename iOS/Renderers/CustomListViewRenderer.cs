using CoreGraphics;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer (typeof (DddByNight.Controls.ListView), typeof (DddByNight.iOS.Renderers.CustomListViewRenderer))]
namespace DddByNight.iOS.Renderers
{
    public class CustomListViewRenderer : ListViewRenderer
    {
        private static UITableView _listView;

        protected override void OnElementChanged (ElementChangedEventArgs<ListView> e)
        {
            base.OnElementChanged (e);

            if (Control != null) {
                _listView = Control;
            }

            if (e.OldElement != null) {
                // Unsubscribe from event handlers and cleanup any resources
            }

            if (e.NewElement != null) {
                // Configure the control and subscribe to event handlers
                _listView.TableFooterView = new UIView (CGRect.Empty);
            }
        }
    }
}

