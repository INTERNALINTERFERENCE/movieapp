using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMDbLib.Objects.Movies;
using TMDbLib.Objects.General;

namespace MovieApp.Shared.Models.MovieData
{
    public class MovieDataDetail
    {
        public int Id { get; set; }
        public string ImdbId { get; set; }
        public string Title { get; set; }
        public string OriginalTitle { get; set; }
        public string Overview { get; set; }
        public double Popularity { get; set; }
        public List<Genre> Genres { get; set; }
        public string Casts { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public KeywordsContainer Keywords { get; set; }
    }
}
