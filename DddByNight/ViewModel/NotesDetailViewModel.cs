using System;
using DddByNight.Model;

namespace DddByNight.ViewModel
{
    public class NotesDetailViewModel
    {
        public NotesDetailViewModel (NoteModel note)
        {
            Note = note;
        }

        public NoteModel Note { get; set; }
    }
}

