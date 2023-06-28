﻿using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using TallerProgramacion2020.MediaManager.Domain;

namespace TallerProgramacion2020.MediaManager.ApiAccess.ImdbApi
{
    internal class OmdbApiMediaFinder : IMediaFinder
    {
        protected const string iApiUrl = "http://www.omdbapi.com/";
        protected const string iApiKey = "?apikey=8c8fc255";
        protected HttpClient iHttpClient;

        public OmdbApiMediaFinder()
        {
            iHttpClient = new HttpClient();
            iHttpClient.BaseAddress = new Uri(iApiUrl);
            iHttpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("text/plain"));
        }

        public IList<Media> FindMedia(string pTitle, Genre pGenre = null, MediaType? pType = null, int pPage = 1)
        {
            var parameters = iApiKey + "&s=" + pTitle + "&page=" + pPage;

            if (pType == MediaType.Movie)
            {
                parameters += "&type=movie";
            }
            else if (pType == MediaType.Series)
            {
                parameters += "&type=series";
            }

            var response = iHttpClient.GetAsync(parameters).Result;
            var mediaResponse = new List<Media>();

            if (response.IsSuccessStatusCode)
            {
                var jsonString = response.Content.ReadAsStringAsync().Result;
                /*var writer = new StreamWriter("C:/Users/User/Documents/TallerDeProgramacion/mediaFinderResults.txt", true);
                writer.WriteLine(jsonString);
                writer.Dispose();*/
                var jsSerializer = new JavaScriptSerializer();
                var mediaSearch = jsSerializer.Deserialize<OmdbApiMediaSearch>(jsonString);
                if (mediaSearch.Response == true)
                {
                    foreach (var mediaDTO in mediaSearch.Search)
                    {
                        var media = GetMediaByImdbID(mediaDTO.imdbID);
                        if (pGenre == null || media.Genres.Any(genre => genre.Equals(pGenre)))
                        {
                            mediaResponse.Add(media);
                        }
                    }
                }
            }
            return mediaResponse;
        }

        public Media GetMediaByImdbID(string pImdbID)
        {
            var response = iHttpClient.GetAsync(iApiKey + "&i=" + pImdbID).Result;
            var mediaResponse = new Media();
            if (response.IsSuccessStatusCode)
            {
                var jsonString = response.Content.ReadAsStringAsync().Result;
                /*var writer = new StreamWriter("C:/Users/User/Documents/TallerDeProgramacion/mediaFinderResults.txt", true);
                writer.WriteLine(jsonString);
                writer.Dispose();*/
                var jsSerializer = new JavaScriptSerializer();
                var mediaDTO = jsSerializer.Deserialize<OmdbApiMediaDTO>(jsonString);
                mediaResponse = mediaDTO.AsMedia;
            }
            return mediaResponse;
        }
    }
}
