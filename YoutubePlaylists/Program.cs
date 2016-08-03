using System;



namespace YoutubePlaylists
{
    class Program
    {
        static void Main(string[] args)
        {
            playlist playList = new playlist("API_KEY");
           string[] videos = playList.getVideos("PLsgo2fbJ-_T2o1dtJVl2nXFo4X-wFBD6a");

            foreach(string video in videos)
            {
                Console.WriteLine(video);
            }
            Console.ReadLine();

        }

        
    }
}
