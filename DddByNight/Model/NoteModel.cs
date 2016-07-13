using System;

namespace DddByNight.Model
{
    public class NoteModel
    {
        public string Id { get; set; }
        public DateTimeOffset DateStamp { get; set; }
        public string Note { get; set; }

        public string DateDisplay
        {
            get {
                return DateStamp.ToString ("g");
            }
        }
    }
}

