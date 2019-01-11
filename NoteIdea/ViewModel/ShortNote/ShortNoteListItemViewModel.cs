
namespace NoteIdea
{
   public class ShortNoteListItemViewModel : BaseViewModel
    { 
        /// <summary>
        /// Title of the note
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Content of the note
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// Status of the note. The note can have one fo three basic status. 
        /// Unimportant - Green color
        /// Normal - Orange color
        /// Important - Red color
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Properies to styling a notes
        /// </summary>
        public bool isSelected { get; set; }

        /// <summary>
        /// Properties to get information where this note comes from. For example:
        /// User deleted a note from our archived list so this lastStat will be: achieved.
        /// If a user decides to restore this note, it will back to an archived list
        /// </summary>
        public bool lastState { get; set; }
    }
}
