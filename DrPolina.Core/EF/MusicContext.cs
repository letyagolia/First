using DrPolina.Domain.Entitties;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DrPolina.Core.EF
{
    public class MusicContext: DbContext
    {
        public DbSet<Album> Albums { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Track> Tracks { get; set; }

        public MusicContext(DbContextOptions<MusicContext> opt) : base(opt)
        {
            Database.EnsureCreated();
        }


    }
}
