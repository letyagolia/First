using System;
using System.Collections.Generic;
using System.Text;

namespace DrPolina.Domain.Entitties
{
    public class Artist
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<Album> Albums { get; set; } = new List<Album>();
    }
}
