using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading.Tasks;
using DddByNight.Model;
using PropertyChanged;
using Xamarin.Forms;

namespace DddByNight.ViewModel
{
    [ImplementPropertyChanged]
    public class AddNoteViewModel
    { 
        private Page _page;

        public AddNoteViewModel (Page page)
        {
            _page = page;
        }

        public string NoteText { get; set; }

        public Command AddNoteCommand {
            get {
                return new Command (async () => await AddNote ());
            }
        }

        private async Task AddNote()
        {
            await Task.Run (() => App.Database.Add (
                                new NoteModel { 
                                    Id = Guid.NewGuid ().ToString (), 
                                    DateStamp = DateTimeOffset.Now, 
                                    Note = NoteText })
                           );

            NoteText = "";

            try {
                await _page.Navigation.PopModalAsync ();
            } catch { }
        }
    }
}

