using System;
using System.Collections.ObjectModel;

namespace NoteIdea
{
    class NotesModel: BaseViewModel
    {
        private ObservableCollection<ShortNoteListItemViewModel> _notes;

        private ObservableCollection<ShortNoteListItemViewModel> _allNotes = new ObservableCollection<ShortNoteListItemViewModel>
        {
            new ShortNoteListItemViewModel
                {
                    Title = "all",
                    Content = "Po powrocie na ziemie polskie został królem. Miał dwóch synów (Kraka II, Lecha II) i jedną córkę. Jego synowie mieli zabić groźnego Smoka Wawelskiego, a jeden z nich przez zawiść zabił brata[1]. Inna legenda podaje, że sam Krak był pogromcą smoka[2]. Córka stała się bohaterką legendy „O Wandzie, która nie chciała Niemca",
                    Status = "#00b348"
                 },
            new ShortNoteListItemViewModel
                {
                    Title = "all",
                    Content = "Po powrocie na ziemie polskie został królem. Miał dwóch synów (Kraka II, Lecha II) i jedną córkę. Jego synowie mieli zabić groźnego Smoka Wawelskiego, a jeden z nich przez zawiść zabił brata[1]. Inna legenda podaje, że sam Krak był pogromcą smoka[2]. Córka stała się bohaterką legendy „O Wandzie, która nie chciała Niemca",
                    Status = "#00b348"
                 },
        };

        private ObservableCollection<ShortNoteListItemViewModel> _deletedNotes = new ObservableCollection<ShortNoteListItemViewModel>
        {
            new ShortNoteListItemViewModel
                {
                    Title = "deleted",
                    Content = "Po powrocie na ziemie polskie został królem. Miał dwóch synów (Kraka II, Lecha II) i jedną córkę. Jego synowie mieli zabić groźnego Smoka Wawelskiego, a jeden z nich przez zawiść zabił brata[1]. Inna legenda podaje, że sam Krak był pogromcą smoka[2]. Córka stała się bohaterką legendy „O Wandzie, która nie chciała Niemca",
                    Status = "#00b348"
                 },
        };

        private ObservableCollection<ShortNoteListItemViewModel> _archiweddNotes = new ObservableCollection<ShortNoteListItemViewModel>
        {
            new ShortNoteListItemViewModel
                {
                    Title = "archived",
                    Content = "Po powrocie na ziemie polskie został królem. Miał dwóch synów (Kraka II, Lecha II) i jedną córkę. Jego synowie mieli zabić groźnego Smoka Wawelskiego, a jeden z nich przez zawiść zabił brata[1]. Inna legenda podaje, że sam Krak był pogromcą smoka[2]. Córka stała się bohaterką legendy „O Wandzie, która nie chciała Niemca",
                    Status = "#00b348"
                 },
        };

        public ObservableCollection<ShortNoteListItemViewModel> Notes
        {
            get
            {
                if (_notes == null)
                {
                    return _allNotes;
                }

                return _notes;
            }
            set
            {
                _notes = value;
                OnPropertyChanged("Notes");
            }
        }

        public void ChangeCurrentNotes(string notesName)
        {
            switch(notesName)
            {
                case "allNotes":
                    Notes = _allNotes;
                    break;
                case "deletedNotes":
                    Notes = _deletedNotes;
                    break;
                case "archiwedNotes":
                    Notes = _archiweddNotes;
                    break;
            }
        }

        private string _currentTitle;

        public string CurrentTitle
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_currentTitle))
                {
                    if (Notes.Count > 0)
                    {
                        return Notes[CurrentNoteId].Title;
                    } else
                    {
                        return "Dupa";
                    }
                }


                return _currentTitle;
            }
            set
            {
                _currentTitle = value;
                OnPropertyChanged("CurrentTitle");
            }
        }


        public void SetNotesId()
        {
            for (int i = 0; i < Notes.Count; i++)
            {
                Notes[i].Id = i;
            }
        }

        public int _currentNoteId;

        public int CurrentNoteId
        {
            get
            {
                return _currentNoteId;
            }
            set
            {
                _currentNoteId = value;
                OnPropertyChanged("CurrentNoteId");
            }
        }

        public void ToArchived()
        {
            ShortNoteListItemViewModel toArchived = Notes[CurrentNoteId];
            _archiweddNotes.Add(toArchived);
            Notes.RemoveAt(CurrentNoteId);
            CurrentNoteId = 0;
            CurrentTitle = "";
        }

        public void ToDeleted()
        {
            ShortNoteListItemViewModel toDeleted = Notes[CurrentNoteId];
            _deletedNotes.Add(toDeleted);
            Notes.RemoveAt(CurrentNoteId);
            CurrentNoteId = 0;
            CurrentTitle = "";
        }
    }
}
