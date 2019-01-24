using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteIdea.ViewModel
{
    class ArchivedNotes : ShortNoteListViewModel
    {
        public ArchivedNotes()
        {
            Notes = new List<ShortNoteListItemViewModel>
                {
                    new ShortNoteListItemViewModel
                    {
                        Title = "ArchivedNotes",
                        Content = "Po powrocie na ziemie polskie został królem. Miał dwóch synów (Kraka II, Lecha II) i jedną córkę. Jego synowie mieli zabić groźnego Smoka Wawelskiego, a jeden z nich przez zawiść zabił brata[1]. Inna legenda podaje, że sam Krak był pogromcą smoka[2]. Córka stała się bohaterką legendy „O Wandzie, która nie chciała Niemca",
                        Status = "#00b348"
                    },
                };
        }
    }
}
