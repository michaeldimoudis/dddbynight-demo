using System;
using System.Collections.Generic;
using DddByNight.ViewModel;
using Xamarin.Forms;

namespace DddByNight.View
{
    public partial class AddNotePage : ContentPage
    {
        public AddNotePage ()
        {
            InitializeComponent ();

            BindingContext = new AddNoteViewModel (this);
        }
    }
}

