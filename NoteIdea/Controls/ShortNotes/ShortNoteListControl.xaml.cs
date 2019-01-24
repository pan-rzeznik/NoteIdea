using System;
using System.Windows.Controls;
using NoteIdea.ViewModel;

namespace NoteIdea
{
    /// <summary>
    /// Interaction logic for ShortNotesListConrol.xaml
    /// </summary>
    public partial class ShortNotesListConrol : UserControl
    {
        public static ShortNotesListConrol Instance => new ShortNotesListConrol();

        public ShortNotesListConrol()
        {
           InitializeComponent();
            DataContext = new AllNotes();
        }

        public void ChangeContext(ShortNoteListViewModel ctx)
        {
            this.DataContext = ctx;
        }
    }
}
