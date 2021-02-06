using MovieApp.Shared.Models.MovieData;
using MovieApp.Shared.Services.JsonReader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMDbLib.Client;
using TMDbLib.Objects.Movies;

namespace MovieApp.Shared.Services
{
    public class TmdbApi
    {
        //TODO: use config
        //private JsonConfig JsonConfig = new JsonConfig();

        private TMDbClient _client = new TMDbClient("dd47404357d7dfca4f753c17e666f789");
        public Task<IEnumerable<MovieDataDetail>> Search(string title)
            => _client.SearchMovieAsync(title, "ru")
            .ContinueWith(async res => (await res).Results.Select(x => new MovieDataDetail
            {
                Id = x.Id,
                Title = x.Title,
                OriginalTitle = x.OriginalTitle,
                Overview = x.Overview,
                ReleaseDate = x.ReleaseDate,
                Popularity = x.Popularity
            }))
            .Unwrap();       
    }
}
