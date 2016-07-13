using System.Collections.Generic;
using DddByNight.Model;
using DddByNight.View;
using Xamarin.Forms;

namespace DddByNight
{
    public partial class App : Application
    {
        public static List<NoteModel> Database { get; set; } = new List<NoteModel> ();

        public App ()
        {
            InitializeComponent ();

            MainPage = BuildMainUi ();
        }

        private TabbedPage BuildMainUi()
        {
            var addNotePage = new AddNotePage () {
                Title = "Add Note"
            };

            var notesListPage = new NavigationPage(new NotesListPage { Title = "Notes List" }) {
                Title = "Notes"
            };

            return new TabbedPage {
                Children = { addNotePage, notesListPage }
            };
        }

        protected override void OnStart ()
        {
            // Handle when your app starts
        }

        protected override void OnSleep ()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume ()
        {
            // Handle when your app resumes
        }
    }
}

