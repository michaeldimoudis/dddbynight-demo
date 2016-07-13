namespace DddByNight.Controls
{
    using System.Windows.Input;
    using Xamarin.Forms;

    public class FloatingButton : AbsoluteLayout
    {
        private StackLayout innerLayout;

        public static readonly BindableProperty TapCommandProperty =
            BindableProperty.Create (nameof (TapCommandProperty), typeof (ICommand), typeof (FloatingButton));
        
        public static IFloatingButton FloatingButtonImplementation {
            get {
                return DependencyService.Get<IFloatingButton> ();
            }
        }

        public static bool HasFloatingButtonImplementation {
            get {
                return FloatingButtonImplementation != null;
            }
        }

        public TapGestureRecognizer tapGesture = new TapGestureRecognizer ();

        public FloatingButton ()
        {
            if (!HasFloatingButtonImplementation) {
                this.IsVisible = false;
                return;
            }

            VerticalOptions = LayoutOptions.FillAndExpand;
            HorizontalOptions = LayoutOptions.FillAndExpand;

            innerLayout = new StackLayout {
                Padding = 8,
                HorizontalOptions = LayoutOptions.Center,
            };

            tapGesture.Tapped += (s, e) => {
                if (e == null || TapCommand == null || !TapCommand.CanExecute (e)) return;
                TapCommand.Execute (null);
            };

            View floatingButton = FloatingButtonImplementation.BuildFloatingButton ();
            floatingButton.GestureRecognizers.Add (tapGesture);

            innerLayout.Children.Add (floatingButton);
            Children.Add (innerLayout);

            SetLayoutFlags (innerLayout, AbsoluteLayoutFlags.PositionProportional);
            SetLayoutBounds (innerLayout, new Rectangle (1f, 1f, AutoSize, AutoSize));
        }

        public ICommand TapCommand {
            get { return (ICommand)GetValue (TapCommandProperty); }
            set { SetValue (TapCommandProperty, value); }
        }
    }
}

