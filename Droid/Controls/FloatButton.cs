[assembly: Xamarin.Forms.Dependency (typeof (DddByNight.Droid.Controls.FloatButton))]
namespace DddByNight.Droid.Controls
{
    using Android.Support.Design.Widget;
    using DddByNight.Controls;
    using Xamarin.Forms;
    using Xamarin.Forms.Platform.Android;

    public class FloatButton : IFloatingButton
    {
        public View BuildFloatingButton ()
        {
            var fab = new FloatingActionButton (Forms.Context) {
                UseCompatPadding = true
            };
            fab.SetImageResource (Droid.Resource.Drawable.ic_finger_buzzer);

            var view = fab.ToView ();

            var tapGesture = new TapGestureRecognizer {
                Command = new Command (
                    () => {
                        //Toast.MakeText (Forms.Context, "Event in Android", ToastLength.Long).Show ();
                    })

            };

            view.GestureRecognizers.Add (tapGesture);

            return view;
        }
    }
}

