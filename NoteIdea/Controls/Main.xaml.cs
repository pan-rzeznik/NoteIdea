using System;
using System.Windows;
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

        private void AddNew_Clicked(object sender, RoutedEventArgs e)
        {
            NotesList.Visibility = Visibility.Hidden;
        }

        private void AllNotes_Clicked(object sender, RoutedEventArgs e)
        {
            Archive.Visibility = Visibility.Visible;
            Delete.Visibility = Visibility.Visible;
            NotesList.Visibility = Visibility.Visible;

            _notes.CurrentNoteId = 0;
            _notes.ChangeCurrentNotes("allNotes");
        }
        
        private void DeletedNotes_Clicked(object sender, RoutedEventArgs e)
        {
            Archive.Visibility = Visibility.Visible;
            Delete.Visibility = Visibility.Hidden;
            NotesList.Visibility = Visibility.Visible;

            _notes.CurrentNoteId = 0;
            _notes.ChangeCurrentNotes("deletedNotes");
        }

        private void ArchivedNotes_Clicked(object sender, RoutedEventArgs e)
        {
            Delete.Visibility = Visibility.Visible;
            Archive.Visibility = Visibility.Hidden;
            NotesList.Visibility = Visibility.Visible;

            _notes.CurrentNoteId = 0;
            _notes.ChangeCurrentNotes("archiwedNotes");
        }

        private void Note_Clicked(object sender, RoutedEventArgs e)
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
                string title = textBox.Text;

                if (_notes.CurrentNoteId > 0)
                {
                    _notes.Notes[_notes.CurrentNoteId].Title = title;
                }
            }
        }

        private void NoteArchive_Clicked(object sender, RoutedEventArgs e)
        {
            if (_notes.Notes.Count > 0)
            {
                _notes.ToArchived();
            }
        }

        private void NoteDelete_Clicked(object sender, RoutedEventArgs e)
        {
            if (_notes.Notes.Count > 0)
            {
                _notes.ToDeleted();
            }
        }
    }
}
