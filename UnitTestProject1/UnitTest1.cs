using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NoteIdea;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddNew()
        {
            NotesModel notesModel = new NotesModel();
            int prevCount = notesModel.Notes.Count;
            notesModel.AddNew();

            Assert.AreEqual(prevCount + 1, notesModel.Notes.Count);
        }

        [TestMethod]
        public void ChangeCurrentNotes_Deleted()
        {
            NotesModel notesModel = new NotesModel();
            notesModel.ChangeCurrentNotes("deletedNotes");

            Assert.AreEqual(1, notesModel.Notes.Count);
            Assert.AreEqual("deleted", notesModel.Notes[0].Title);
        }

        [TestMethod]
        public void ChangeCurrentNotes_All()
        {
            NotesModel notesModel = new NotesModel();
            notesModel.ChangeCurrentNotes("alldNotes");

            Assert.AreEqual(1, notesModel.Notes.Count);
            Assert.AreEqual("all", notesModel.Notes[0].Title);
        }

        [TestMethod]
        public void ChangeCurrentNotes_Archived()
        {
            NotesModel notesModel = new NotesModel();
            notesModel.ChangeCurrentNotes("archiwedNotes");

            Assert.AreEqual(1, notesModel.Notes.Count);
            Assert.AreEqual("archived", notesModel.Notes[0].Title);
        }

        [TestMethod]
        public void SetNotesId()
        {
            NotesModel notesModel = new NotesModel();
            notesModel.SetNotesId();

            Assert.AreEqual(0, notesModel.Notes[0].Id);
        }

        [TestMethod]
        public void SetNotesId_1()
        {
            NotesModel notesModel = new NotesModel();
            notesModel.AddNew();
            notesModel.SetNotesId();

            Assert.AreEqual(1, notesModel.Notes[1].Id);
        }

        [TestMethod]
        public void ToArchived()
        {
            NotesModel notesModel = new NotesModel();

            notesModel.ToArchived();
            notesModel.ChangeCurrentNotes("archiwedNotes");

            Assert.AreEqual(2, notesModel.Notes.Count);
        }

        [TestMethod]
        public void ToArchived_Title()
        {
            NotesModel notesModel = new NotesModel();

            string title = notesModel.Notes[0].Title;
            notesModel.ToArchived();
            notesModel.ChangeCurrentNotes("archiwedNotes");

            Assert.AreEqual(title, notesModel.Notes[1].Title);
        }

        [TestMethod]
        public void ToDeleted()
        {
            NotesModel notesModel = new NotesModel();

            notesModel.ToDeleted();
            notesModel.ChangeCurrentNotes("deletedNotes");

            Assert.AreEqual(2, notesModel.Notes.Count);
        }

        [TestMethod]
        public void ToADeleted_Title()
        {
            NotesModel notesModel = new NotesModel();

            string title = notesModel.Notes[0].Title;
            notesModel.ToDeleted();
            notesModel.ChangeCurrentNotes("deletedNotes");

            Assert.AreEqual(title, notesModel.Notes[1].Title);
        }

        [TestMethod]
        public void ToAll()
        {
            NotesModel notesModel = new NotesModel();

            notesModel.ChangeCurrentNotes("deletedNotes");
            notesModel.ToAll();
            notesModel.ChangeCurrentNotes("allNotes");

            Assert.AreEqual(2, notesModel.Notes.Count);
        }

        [TestMethod]
        public void ToAll_Title()
        {
            NotesModel notesModel = new NotesModel();

            notesModel.ChangeCurrentNotes("deletedNotes");
            string title = notesModel.Notes[0].Title;
            notesModel.ToAll();
            notesModel.ChangeCurrentNotes("allNotes");

            Assert.AreEqual(title, notesModel.Notes[1].Title);
        }
    }
}
