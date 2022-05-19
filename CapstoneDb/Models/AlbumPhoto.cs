using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace CapstoneDb.Models
{
    public class AlbumPhoto
    {
        [Key]
        public Guid AlbumPhotoId { get; set; }
        [Required]
        public string AlbumPhotoPath { get; set; }
        //FK
        public Guid AlbumId { get; set; }
        public virtual Album Album { get; set; }
    }
}
