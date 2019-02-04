using System;
using System.Linq;
using System.Windows.Controls;

namespace NoteIdea
{
    /// <summary>
    /// Interaction logic for Main.xaml
    /// </summary>
    public partial class Main : UserControl
    {
        NotesModel _notes = new NotesModel();

        public Main()
        {
            InitializeComponent();
            this.DataContext = _notes;
            _notes.SetNotesId();
        }

        private void AllNotes_Clicked(object sender, System.Windows.RoutedEventArgs e)
        {
            _notes.CurrentNoteId = 0;
            _notes.ChangeCurrentNotes("allNotes");
        }

        private void DeletedNotes_Clicked(object sender, System.Windows.RoutedEventArgs e)
        {
            _notes.CurrentNoteId = 0;
            _notes.ChangeCurrentNotes("deletedNotes");
        }

        private void ArchivedNotes_Clicked(object sender, System.Windows.RoutedEventArgs e)
        {
            _notes.CurrentNoteId = 0;
            _notes.ChangeCurrentNotes("archiwedNotes");
        }

        private void Note_Clicked(object sender, System.Windows.RoutedEventArgs e)
        {
            _notes.SetNotesId();
            var button = (Button)sender;
            int id = Convert.ToInt32(button.Tag);
            Console.WriteLine(id);
            _notes.CurrentNoteId = id;
        }

        private void CurrentTitle_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null)
            {
                string theText = textBox.Text;
                _notes.Notes[_notes.CurrentNoteId].Title = theText;
            }
        }

        private void NoteArchive_Clicked(object sender, System.Windows.RoutedEventArgs e)
        {
            _notes.ToArchived();
        }

        private void NoteDelete_Clicked(object sender, System.Windows.RoutedEventArgs e)
        {
            _notes.ToDeleted();
        }
    }
}
