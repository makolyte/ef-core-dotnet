using System;
using System.ComponentModel.DataAnnotations;

namespace ef_core_cli.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Movie
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(500)]
        public string Name { get; set; }

        [Required]
        public int ReleaseYear { get; set; }

        [Required]
        [MaxLength(500)]
        public string Description { get; set; }

        [Required]
        public int RuntimeMinutes { get; set; }
    }
}
