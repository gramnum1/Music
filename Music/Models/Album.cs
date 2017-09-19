using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Music.Models
{
    public class Album
    {
        public int AlbumId { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
    }

    public class MusicContext : DbContext
    {
        public DbSet<Album> Albums { get; set; }
    }
}