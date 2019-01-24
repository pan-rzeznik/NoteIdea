using System;
using System.Windows.Controls;
using NoteIdea.ViewModel;

namespace NoteIdea
{
    /// <summary>
    /// Interaction logic for MainMenuControl.xaml
    /// </summary>
    public partial class MainMenuControl : UserControl
    {
        public MainMenuControl()
        {
            InitializeComponent();
        }

        private void All_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            ShortNotesListConrol.Instance.ChangeContext(new AllNotes());
        }

        private void Archived_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            ShortNotesListConrol.Instance.ChangeContext(new ArchivedNotes());
        }

        private void Deleted_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            ShortNotesListConrol.Instance.ChangeContext(new DeletedNotes());
        }
    }
}
