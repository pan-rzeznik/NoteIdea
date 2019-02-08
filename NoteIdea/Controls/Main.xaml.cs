﻿using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Xml;

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
            Archive.Visibility = Visibility.Visible;
            Delete.Visibility = Visibility.Visible;
            Restore.Visibility = Visibility.Hidden;
            Archive.SetValue(Grid.ColumnProperty, 1);
            Delete.SetValue(Grid.ColumnProperty, 2);

            TextRange textRange = new TextRange(NoteContent.Document.ContentStart, NoteContent.Document.ContentEnd);
            textRange.Text = _notes.Notes[0].Content;
        }

        private void AddNew_Clicked(object sender, RoutedEventArgs e)
        {
            Archive.Visibility = Visibility.Visible;
            Delete.Visibility = Visibility.Visible;
            Restore.Visibility = Visibility.Hidden;
            Archive.SetValue(Grid.ColumnProperty, 1);
            Delete.SetValue(Grid.ColumnProperty, 2);

            _notes.CurrentNoteId = 0;
            _notes.ChangeCurrentNotes("allNotes");
            _notes.AddNew();

            TextRange textRange = new TextRange(NoteContent.Document.ContentStart, NoteContent.Document.ContentEnd);
            textRange.Text = _notes.Notes[_notes.CurrentNoteId].Content;
        }

        private void AllNotes_Clicked(object sender, RoutedEventArgs e)
        {
            Archive.Visibility = Visibility.Visible;
            Delete.Visibility = Visibility.Visible;
            Restore.Visibility = Visibility.Hidden;
            Archive.SetValue(Grid.ColumnProperty, 1);
            Delete.SetValue(Grid.ColumnProperty, 2);

            _notes.CurrentNoteId = 0;
            _notes.ChangeCurrentNotes("allNotes");

            TextRange textRange = new TextRange(NoteContent.Document.ContentStart, NoteContent.Document.ContentEnd);
            textRange.Text = _notes.Notes[_notes.CurrentNoteId].Content;
        }
        
        private void DeletedNotes_Clicked(object sender, RoutedEventArgs e)
        {
            Archive.Visibility = Visibility.Visible;
            Delete.Visibility = Visibility.Hidden;
            Restore.Visibility = Visibility.Visible;
            Restore.SetValue(Grid.ColumnProperty, 1);
            Archive.SetValue(Grid.ColumnProperty, 2);

            _notes.CurrentNoteId = 0;
            _notes.ChangeCurrentNotes("deletedNotes");

            TextRange textRange = new TextRange(NoteContent.Document.ContentStart, NoteContent.Document.ContentEnd);
            textRange.Text = _notes.Notes[_notes.CurrentNoteId].Content;
        }

        private void ArchivedNotes_Clicked(object sender, RoutedEventArgs e)
        {
            Delete.Visibility = Visibility.Visible;
            Archive.Visibility = Visibility.Hidden;
            Restore.Visibility = Visibility.Visible;
            Restore.SetValue(Grid.ColumnProperty, 1);
            Delete.SetValue(Grid.ColumnProperty, 2);

            _notes.CurrentNoteId = 0;
            _notes.ChangeCurrentNotes("archiwedNotes");

            TextRange textRange = new TextRange(NoteContent.Document.ContentStart, NoteContent.Document.ContentEnd);
            textRange.Text = _notes.Notes[_notes.CurrentNoteId].Content;
        }

        private void Note_Clicked(object sender, RoutedEventArgs e)
        {
            _notes.SetNotesId();
            var button = (Button)sender;
            int id = Convert.ToInt32(button.Tag);
            _notes.CurrentNoteId = id;
            TextRange textRange = new TextRange(NoteContent.Document.ContentStart, NoteContent.Document.ContentEnd);
            textRange.Text = _notes.Notes[_notes.CurrentNoteId].Content;
        }

        private void CurrentTitle_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (textBox != null)
            {
                string title = textBox.Text;

                if (_notes.CurrentNoteId >= 0 && _notes.Notes.Count > 0)
                {
                    _notes.Notes[_notes.CurrentNoteId].Title = title;
                }
            }
        }

        private void CurrentContent_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextRange textRange = new TextRange(NoteContent.Document.ContentStart, NoteContent.Document.ContentEnd);
            _notes.Notes[_notes.CurrentNoteId].Content = textRange.Text;
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

        private void NoteRestore_Clicked(object sender, RoutedEventArgs e)
        {
            if (_notes.Notes.Count > 0)
            {
                _notes.ToAll();
            }
        }
    }
}
