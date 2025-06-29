using System;
using System.ComponentModel.DataAnnotations;

namespace LibraryCatalog.Models
{
    public class Book
    {
        [Key]
        public int BookID { get; set; }

        [Required]
        public string Title { get; set; }

        public string Author { get; set; }

        [Required]
        [StringLength(13)]
        public string ISBN { get; set; }

        public int PublishedYear { get; set; }

        public string Genre { get; set; }
    }
}