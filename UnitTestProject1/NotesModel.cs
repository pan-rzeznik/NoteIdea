using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NoteIdea;

namespace UnitTestProject1
{
    [TestClass]
    public class NotesModel
    {
        [TestMethod]
        public void AddNew()
        {
            NoteIdea.NotesModel notesModel = new NoteIdea.NotesModel();
            int prevCount = notesModel.Notes.Count;
            notesModel.AddNew();

            Assert.AreEqual(prevCount + 1, notesModel.Notes.Count);
        }

        [TestMethod]
        public void ChangeCurrentNotes_Deleted()
        {
            NoteIdea.NotesModel notesModel = new NoteIdea.NotesModel();
            notesModel.ChangeCurrentNotes("deletedNotes");

            Assert.AreEqual(1, notesModel.Notes.Count);
            Assert.AreEqual("deleted", notesModel.Notes[0].Title);
        }

        [TestMethod]
        public void ChangeCurrentNotes_All()
        {
            NoteIdea.NotesModel notesModel = new NoteIdea.NotesModel();
            notesModel.ChangeCurrentNotes("alldNotes");

            Assert.AreEqual(1, notesModel.Notes.Count);
            Assert.AreEqual("all", notesModel.Notes[0].Title);
        }

        [TestMethod]
        public void ChangeCurrentNotes_Archived()
        {
            NoteIdea.NotesModel notesModel = new NoteIdea.NotesModel();
            notesModel.ChangeCurrentNotes("archiwedNotes");

            Assert.AreEqual(1, notesModel.Notes.Count);
            Assert.AreEqual("archived", notesModel.Notes[0].Title);
        }

        [TestMethod]
        public void SetNotesId()
        {
            NoteIdea.NotesModel notesModel = new NoteIdea.NotesModel();
            notesModel.SetNotesId();

            Assert.AreEqual(0, notesModel.Notes[0].Id);
        }

        [TestMethod]
        public void SetNotesId_1()
        {
            NoteIdea.NotesModel notesModel = new NoteIdea.NotesModel();
            notesModel.AddNew();
            notesModel.SetNotesId();

            Assert.AreEqual(1, notesModel.Notes[1].Id);
        }

        [TestMethod]
        public void ToArchived()
        {
            NoteIdea.NotesModel notesModel = new NoteIdea.NotesModel();

            notesModel.ToArchived();
            notesModel.ChangeCurrentNotes("archiwedNotes");

            Assert.AreEqual(2, notesModel.Notes.Count);
        }

        [TestMethod]
        public void ToArchived_Title()
        {
            NoteIdea.NotesModel notesModel = new NoteIdea.NotesModel();

            string title = notesModel.Notes[0].Title;
            notesModel.ToArchived();
            notesModel.ChangeCurrentNotes("archiwedNotes");

            Assert.AreEqual(title, notesModel.Notes[1].Title);
        }

        [TestMethod]
        public void ToDeleted()
        {
            NoteIdea.NotesModel notesModel = new NoteIdea.NotesModel();

            notesModel.ToDeleted();
            notesModel.ChangeCurrentNotes("deletedNotes");

            Assert.AreEqual(2, notesModel.Notes.Count);
        }

        [TestMethod]
        public void ToADeleted_Title()
        {
            NoteIdea.NotesModel notesModel = new NoteIdea.NotesModel();

            string title = notesModel.Notes[0].Title;
            notesModel.ToDeleted();
            notesModel.ChangeCurrentNotes("deletedNotes");

            Assert.AreEqual(title, notesModel.Notes[1].Title);
        }

        [TestMethod]
        public void ToAll()
        {
            NoteIdea.NotesModel notesModel = new NoteIdea.NotesModel();

            notesModel.ChangeCurrentNotes("deletedNotes");
            notesModel.ToAll();
            notesModel.ChangeCurrentNotes("allNotes");

            Assert.AreEqual(2, notesModel.Notes.Count);
        }

        [TestMethod]
        public void ToAll_Title()
        {
            NoteIdea.NotesModel notesModel = new NoteIdea.NotesModel();

            notesModel.ChangeCurrentNotes("deletedNotes");
            string title = notesModel.Notes[0].Title;
            notesModel.ToAll();
            notesModel.ChangeCurrentNotes("allNotes");

            Assert.AreEqual(title, notesModel.Notes[1].Title);
        }
    }
}
