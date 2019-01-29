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
        }

        private void AllNotes_Clicked(object sender, System.Windows.RoutedEventArgs e)
        {
            _notes.ChangeCurrentNotes("allNotes");
        }

        private void DeletedNotes_Clicked(object sender, System.Windows.RoutedEventArgs e)
        {
            _notes.ChangeCurrentNotes("deletedNotes");
        }

        private void ArchivedNotes_Clicked(object sender, System.Windows.RoutedEventArgs e)
        {
            _notes.ChangeCurrentNotes("archiwedNotes");
        }
    }
}
