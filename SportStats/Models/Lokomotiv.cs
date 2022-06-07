using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace SportStats.Models
{

    [Table("Lokomotiv")]
    public partial class Lokomotiv
    {
        [Key]
        public string Title { get; set; }
        [Required]
        public string Stadium { get; set; }
        [Required]
        public string Head_Coach { get; set; }
        public int Home_Win { get; set; }
        public int Guest_Win { get; set; }
        public int Home_Goals { get; set; }
        public int Guest_Goals { get; set; }
        public int YellowRoughPlay { get; set; }
        public int YellowUnsportsmanlikeBehavior { get; set; }
        public int YellowDisruptionOfTheAttack { get; set; }
        public int Yellow_Other { get; set; }

        public int Yellow_Cards { get; set; }
        public int Red_Cards { get; set; }

    }
}