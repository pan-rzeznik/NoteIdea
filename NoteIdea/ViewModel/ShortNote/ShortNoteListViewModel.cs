using System.Collections.Generic;

namespace NoteIdea
{
   public class ShortNoteListViewModel
    {
        /// <summary>
        /// List of all notes
        /// </summary>
        public List<ShortNoteListItemViewModel> AllNotes { get; set; }

        /// <summary>
        /// List of all archived notes
        /// </summary>
        public List<ShortNoteListItemViewModel> ArchivedNotes { get; set; }

        /// <summary>
        /// List of deleted notes
        /// </summary>
        public List<ShortNoteListItemViewModel> DeletedNotes { get; set; }
    }
}
