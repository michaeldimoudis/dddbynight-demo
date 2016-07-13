using System;
using System.Collections.Generic;
using DddByNight.Model;
using DddByNight.ViewModel;
using Xamarin.Forms;

namespace DddByNight.View
{
    public partial class NotesDetailPage : ContentPage
    {
        public NotesDetailPage (NoteModel note)
        {
            InitializeComponent ();

            BindingContext = new NotesDetailViewModel (note);
        }
    }
}

