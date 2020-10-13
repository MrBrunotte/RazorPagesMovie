using System;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesMovie.Models
{
    public class Movie
    {
        // ID is required by the database for the primary key.
        public int ID { get; set; }
        public string Title { get; set; }
        // Data Annotation. Only date is displayed, not time
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        public string Genre { get; set; }
        public decimal Price { get; set; }
    }
}