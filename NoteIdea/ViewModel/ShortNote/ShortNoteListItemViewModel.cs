
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
    }
}
