using System;
using System.Collections.Generic;
using DddByNight.ViewModel;
using Xamarin.Forms;

namespace DddByNight.View
{
    public partial class NotesListPage : ContentPage
    {
        public NotesListPage ()
        {
            InitializeComponent ();

            BindingContext = new NotesListViewModel (this);
        }
    }
}

