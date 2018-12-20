using System;
using System.Collections.Generic;

namespace HeroApp.Data.Domain
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string PlotSummary { get; set; }
        public string Image { get; set; }
        public ICollection<Team> Teams { get; } = new List<Team>();
    }
}