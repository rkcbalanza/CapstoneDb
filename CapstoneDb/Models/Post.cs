﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Microsoft.EntityFrameworkCore;
namespace CapstoneDb.Models
{
    public class Post
    {
        public Post()
        {
            Comments = new HashSet<Comment>();
            Likes = new HashSet<Like>();
        }

        [Key]
        public Guid PostId { get; set; }
        public string TextContent { get; set; }
        public string PostPhotoPath { get; set; }
        [Required]
        public DateTime TimeStamp { get; set; }
        [Required]
        public Guid PostLocation { get; set; }

        //FK
        public Guid UserAccountId { get; set; }
        public UserAccount UserAccount { get; set; }
        
        //Relationship
        public ICollection<Like> Likes { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}
