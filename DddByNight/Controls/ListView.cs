using System.Windows.Input;
using Xamarin.Forms;

namespace DddByNight.Controls
{
    public class ListView : Xamarin.Forms.ListView
    {
        public static BindableProperty ItemTappedCommandProperty =
            BindableProperty.Create (nameof (ItemTappedCommand), typeof (ICommand), typeof (ListView));

        public ListView ()
        {
            ItemTapped += OnItemTapped;
        }

        public ICommand ItemTappedCommand {
            get { return (ICommand)GetValue (ItemTappedCommandProperty); }
            set { SetValue (ItemTappedCommandProperty, value); }
        }

        private void OnItemTapped (object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null || ItemTappedCommand == null || !ItemTappedCommand.CanExecute (e)) return;

            ItemTappedCommand.Execute (e.Item);
            SelectedItem = null;
        }
    }
}

