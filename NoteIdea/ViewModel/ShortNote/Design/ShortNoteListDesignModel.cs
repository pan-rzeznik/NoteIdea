
using System.Collections.Generic;

namespace NoteIdea
{
    public class ShortNoteListDesignModel : ShortNoteListViewModel
    {
        public static ShortNoteListDesignModel Instance => new ShortNoteListDesignModel();

        public ShortNoteListDesignModel()
        { 
            Notes = new List<ShortNoteListItemViewModel>
                {
                    new ShortNoteListItemViewModel
                    {
                        Title = "Pierwszy tytuł z view modelu - test",
                        Content = "Po powrocie na ziemie polskie został królem. Miał dwóch synów (Kraka II, Lecha II) i jedną córkę. Jego synowie mieli zabić groźnego Smoka Wawelskiego, a jeden z nich przez zawiść zabił brata[1]. Inna legenda podaje, że sam Krak był pogromcą smoka[2]. Córka stała się bohaterką legendy „O Wandzie, która nie chciała Niemca",
                        Status = "#00b348"
                    },
                     new ShortNoteListItemViewModel
                    {
                        Title = "Kolejne tytuły podawane z kodux a nie z xamla",
                        Content = "Wykład o Kraku zaczyna się u Kadłubka po zakończeniu wojny z Rzymianami, gdzie jest wspomniane, że Prapolacy (nazwa stworzona na potrzeby tego artykułu; u kronikarza nienazwany ogół słowiański[7]) wybrali Kraka na księcia. Następnie Kadłubek opisuje w skrócie dzieje innego wielkiego plemienia, które jako jedyne mogło się wtedy mierzyć z Polakami – Gallów.",
                        Status = "#ac1225"
                    },
                      new ShortNoteListItemViewModel
                    {
                        Title = "Kupić mleko i pierogi",
                        Content = "Kiedy działalność ustawodawcza została ukończona Kadłubek pierwszy raz używa terminu „Polska”, którą Krak miał doprowadzić do „świetnego rozkwitu”. Rozkwit jednak nie trwał długo, ponieważ nowo stworzone państwo napotkało na swojej drodze nowy problem w postaci potwora zwanego „całożercą”[14]. Jak pisze mistrz Wincenty miał on terroryzować poddanych Kraka żądaniem ofiary z bydła, którego dostaw wymagał co tydzień. Jeżeliby ofiara nie została dokonana miał zjadać tylu ludzi ile bydła miało być mu dostarczone.",
                        Status = "#ac1225"
                    },
                         new ShortNoteListItemViewModel
                    {
                        Title = "Kupić mleko i pierogi bo nie wiem czy kupiłem ostatnio",
                        Content = "Kiedy działalność ustawodawcza została ukończona Kadłubek pierwszy raz używa terminu „Polska”, którą Krak miał doprowadzić do „świetnego rozkwitu”. Rozkwit jednak nie trwał długo, ponieważ nowo stworzone państwo napotkało na swojej drodze nowy problem w postaci potwora zwanego „całożercą”[14]. Jak pisze mistrz Wincenty miał on terroryzować poddanych Kraka żądaniem ofiary z bydła, którego dostaw wymagał co tydzień. Jeżeliby ofiara nie została dokonana miał zjadać tylu ludzi ile bydła miało być mu dostarczone.",
                        Status = "#ac1225"
                    },
                           new ShortNoteListItemViewModel
                    {
                        Title = "Kolejne tytuły podawane z kodux a nie z xamla",
                        Content = "Wykład o Kraku zaczyna się u Kadłubka po zakończeniu wojny z Rzymianami, gdzie jest wspomniane, że Prapolacy (nazwa stworzona na potrzeby tego artykułu; u kronikarza nienazwany ogół słowiański[7]) wybrali Kraka na księcia. Następnie Kadłubek opisuje w skrócie dzieje innego wielkiego plemienia, które jako jedyne mogło się wtedy mierzyć z Polakami – Gallów.",
                        Status = "#ac1225"
                    },
                      new ShortNoteListItemViewModel
                    {
                        Title = "Kupić mleko i pierogi",
                        Content = "Kiedy działalność ustawodawcza została ukończona Kadłubek pierwszy raz używa terminu „Polska”, którą Krak miał doprowadzić do „świetnego rozkwitu”. Rozkwit jednak nie trwał długo, ponieważ nowo stworzone państwo napotkało na swojej drodze nowy problem w postaci potwora zwanego „całożercą”[14]. Jak pisze mistrz Wincenty miał on terroryzować poddanych Kraka żądaniem ofiary z bydła, którego dostaw wymagał co tydzień. Jeżeliby ofiara nie została dokonana miał zjadać tylu ludzi ile bydła miało być mu dostarczone.",
                        Status = "#ac1225"
                    },
                         new ShortNoteListItemViewModel
                    {
                        Title = "Kupić mleko i pierogi bo nie wiem czy kupiłem ostatnio",
                        Content = "Kiedy działalność ustawodawcza została ukończona Kadłubek pierwszy raz używa terminu „Polska”, którą Krak miał doprowadzić do „świetnego rozkwitu”. Rozkwit jednak nie trwał długo, ponieważ nowo stworzone państwo napotkało na swojej drodze nowy problem w postaci potwora zwanego „całożercą”[14]. Jak pisze mistrz Wincenty miał on terroryzować poddanych Kraka żądaniem ofiary z bydła, którego dostaw wymagał co tydzień. Jeżeliby ofiara nie została dokonana miał zjadać tylu ludzi ile bydła miało być mu dostarczone.",
                        Status = "#ac1225"
                    },
                           new ShortNoteListItemViewModel
                    {
                        Title = "Kolejne tytuły podawane z kodux a nie z xamla",
                        Content = "Wykład o Kraku zaczyna się u Kadłubka po zakończeniu wojny z Rzymianami, gdzie jest wspomniane, że Prapolacy (nazwa stworzona na potrzeby tego artykułu; u kronikarza nienazwany ogół słowiański[7]) wybrali Kraka na księcia. Następnie Kadłubek opisuje w skrócie dzieje innego wielkiego plemienia, które jako jedyne mogło się wtedy mierzyć z Polakami – Gallów.",
                        Status = "#ac1225"
                    },
                      new ShortNoteListItemViewModel
                    {
                        Title = "Kupić mleko i pierogi",
                        Content = "Kiedy działalność ustawodawcza została ukończona Kadłubek pierwszy raz używa terminu „Polska”, którą Krak miał doprowadzić do „świetnego rozkwitu”. Rozkwit jednak nie trwał długo, ponieważ nowo stworzone państwo napotkało na swojej drodze nowy problem w postaci potwora zwanego „całożercą”[14]. Jak pisze mistrz Wincenty miał on terroryzować poddanych Kraka żądaniem ofiary z bydła, którego dostaw wymagał co tydzień. Jeżeliby ofiara nie została dokonana miał zjadać tylu ludzi ile bydła miało być mu dostarczone.",
                        Status = "#ac1225"
                    },
                         new ShortNoteListItemViewModel
                    {
                        Title = "Kupić mleko i pierogi bo nie wiem czy kupiłem ostatnio",
                        Content = "Kiedy działalność ustawodawcza została ukończona Kadłubek pierwszy raz używa terminu „Polska”, którą Krak miał doprowadzić do „świetnego rozkwitu”. Rozkwit jednak nie trwał długo, ponieważ nowo stworzone państwo napotkało na swojej drodze nowy problem w postaci potwora zwanego „całożercą”[14]. Jak pisze mistrz Wincenty miał on terroryzować poddanych Kraka żądaniem ofiary z bydła, którego dostaw wymagał co tydzień. Jeżeliby ofiara nie została dokonana miał zjadać tylu ludzi ile bydła miało być mu dostarczone.",
                        Status = "#ac1225"
                    },
                };
        }
    }
}