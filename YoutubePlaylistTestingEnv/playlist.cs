using System.Collections.Generic;
using Google.Apis.Services;
using Google.Apis.YouTube.v3;

namespace YoutubePlaylistTestingEnv
{
    class playlist
    {
        /// <summary>
        /// Returns all videos inside a playlist
        /// </summary>
        /// <param name="APIKey">Your API Key</param>
        /// <param name="playlistID"> The playlist URL</param>
        /// <param name="type"> If you don't know what this is, leave it as it is </param>
        /// <returns> string array of all the video IDs inside the playlist</returns>
        public string[] getVideos(string APIKey, string playlistID, string type = "contentDetails")
        {
            BaseClientService.Initializer apiConnection = new BaseClientService.Initializer();
            apiConnection.ApiKey = APIKey;
            List<string> IDs = new List<string> { };


            var youtubeService = new YouTubeService(apiConnection);

            string nextPageToken = "";
            while (nextPageToken != null)
            {
                var getPlaylistVideos = youtubeService.PlaylistItems.List(type);
                getPlaylistVideos.PlaylistId = playlistID;
                getPlaylistVideos.MaxResults = 50;
                getPlaylistVideos.PageToken = nextPageToken;
                var getVideos = getPlaylistVideos.Execute();

                foreach (var video in getVideos.Items)
                {
                    IDs.Add(video.ContentDetails.VideoId);
                }
                nextPageToken = getVideos.NextPageToken;
            }
            return IDs.ToArray();
        }
    }
}
