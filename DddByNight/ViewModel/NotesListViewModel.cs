using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using DddByNight.Model;
using DddByNight.View;
using Xamarin.Forms;

namespace DddByNight.ViewModel
{
    public class NotesListViewModel
    {
        private Page _page;

        public NotesListViewModel (Page page)
        {
            _page = page;

            _page.Appearing += (sender, e) => {
                Notes.Clear ();
                foreach (var note in App.Database)
                {
                    Notes.Add (note);
                }
            };
        }

        public ObservableCollection<NoteModel> Notes { get; set; } = new ObservableCollection<NoteModel> ();

        public Command<NoteModel> ItemTappedCommand {
            get {
                return new Command<NoteModel> (async note => await NavigateToDetail(note));
            }
        }

        public async Task NavigateToDetail(NoteModel note)
        {
            await _page.Navigation.PushAsync (new NotesDetailPage (note));
        }

        public Command OnFloatButtonTap {
            get {
                return new Command (
                    async () => {
                        await _page.Navigation.PushModalAsync (new AddNotePage ());
                    });
            }
        }
    }
}

