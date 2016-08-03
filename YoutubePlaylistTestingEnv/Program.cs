using System;



namespace YoutubePlaylistTestingEnv
{
    class Program
    {
        static void Main(string[] args)
        {
            playlist playList = new playlist();
           string[] videos = playList.getVideos("API_KEY", "PLsgo2fbJ-_T2o1dtJVl2nXFo4X-wFBD6a");

            foreach(string video in videos)
            {
                Console.WriteLine(video);
            }
            Console.ReadLine();

        }

        
    }
}
