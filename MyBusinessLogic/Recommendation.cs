
using System;

namespace MyBusinessLogic
{

    public class Recomendation
    {
        public static void Main(string[] args) { }


        public string name;
        List<Content> context = new List<Content>();
    
        public void AddAnime(Content anime)
        {
            context.Add(anime);
        }
        public void SearchAnime(string title)
        {
            Console.WriteLine("MY ANIME RECCOMENDATION" +
                              "\n  " +
                              "\n____________________________________________________" +
                              "\nCardcaptor Sakura" +
                              "\n____________________________________________________" +
                              "\nSolo Leveling" +
                              "\n____________________________________________________" +
                              "\nYume-iro Pâtissière" +
                              "\n____________________________________________________" +
                              "\nMob Psycho 100" +
                              "\n____________________________________________________" +
                              "\nHaikyu!!" +
                              "\n____________________________________________________" +
                              "\n  ");
            Console.WriteLine("PICK ANY ANIME TO KNOW MORE ABOUT: " + "\n   ");
            title = Console.ReadLine();
            Console.WriteLine("   ");
            Console.WriteLine("____________________________________________________");

            foreach (var anime in context)
            {
                if (anime.title.Contains(title))
                {
                    DisplayAnimeInfo(anime);
                }
            }
        }
        public void DisplayAnimeInfo(Content anime)
        {
            Console.WriteLine("ANIME INFORMATION ABOUT " + name + "...");
            Console.WriteLine("____________________________________________________");
            Console.WriteLine("TITLE: " + anime.title);
            Console.WriteLine("STUDIO: " + anime.studio);
            Console.WriteLine("RELEASE DATE: " + anime.releasedate);
            Console.WriteLine("STATUS: " + anime.status);
            Console.WriteLine("GENRE: " + anime.genre);
            Console.WriteLine("EPISODES: " + anime.episodes);
            Console.WriteLine("SUMMARY: " + anime.summary);
            Console.WriteLine("____________________________________________________");
        }
    }
}
