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
        [StringLength(maximumLength: 250, MinimumLength = 1)]
        public string Name { get; set; }

        [Required]
        [Range(1888, 9999)]
        public int ReleaseYear { get; set; }

        [Required]
        [StringLength(maximumLength: 500, MinimumLength = 1)]
        public string Description { get; set; }

        [Required]
        [Range(0, 300)]
        public int RuntimeMinutes { get; set; }
        

    }
}
