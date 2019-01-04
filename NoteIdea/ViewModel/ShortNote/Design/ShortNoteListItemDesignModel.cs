namespace NoteIdea
{
    public class ShortNoteListItemDesignModel : ShortNoteListItemViewModel
    {
        public static ShortNoteListItemDesignModel Instance => new ShortNoteListItemDesignModel();

        public ShortNoteListItemDesignModel()
        {
            Title = "Pierwszy tytuł z view modelu - design test ";
            Content = "Po powrocie na ziemie polskie został królem. Miał dwóch synów (Kraka II, Lecha II) i jedną córkę. Jego synowie mieli zabić groźnego Smoka Wawelskiego, a jeden z nich przez zawiść zabił brata[1]. Inna legenda podaje, że sam Krak był pogromcą smoka[2]. Córka stała się bohaterką legendy „O Wandzie, która nie chciała Niemca";
            Status = "StatusGreen";
        }
    }
}


