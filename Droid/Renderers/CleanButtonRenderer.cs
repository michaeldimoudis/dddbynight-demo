using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using DddByNight.Droid.Renderers;
using DddByNight.Controls;

[assembly: ExportRenderer (typeof (CleanButton), typeof (CleanButtonRenderer))]
namespace DddByNight.Droid.Renderers
{
    public class CleanButtonRenderer : Xamarin.Forms.Platform.Android.AppCompat.ButtonRenderer
    {
        private static Android.Widget.Button _button;

        protected override void OnElementChanged (ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged (e);

            if (Control != null) {
                _button = Control;
            }

            if (e.OldElement != null) {
                // Unsubscribe from event handlers and cleanup any resources
            }

            if (e.NewElement != null) {
                // Configure the control and subscribe to event handlers
                _button.SetBackgroundColor (global::Android.Graphics.Color.Transparent);
                _button.SetShadowLayer (0, 0, 0, global::Android.Graphics.Color.Transparent);
                _button.SetTextColor (global::Android.Graphics.Color.Blue);
            }
        }
    }
}

