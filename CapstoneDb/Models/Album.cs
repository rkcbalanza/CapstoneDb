using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace CapstoneDb.Models
{
    public class Album
    {
        public Album()
        {
            AlbumPhotos = new HashSet<AlbumPhoto>();
        }
        public Guid AlbumId { get; set; }
        public string AlbumName { get; set; }

        //FK
        public Guid UserAccountId { get; set; }
        public virtual UserAccount UserAccount { get; set; }

        //Relationship
        public virtual ICollection<AlbumPhoto> AlbumPhotos { get; set; }
    }
}
