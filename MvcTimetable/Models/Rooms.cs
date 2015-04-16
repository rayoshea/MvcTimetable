using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MvcTimetable.Models
{
    public class Rooms
    {
        [Required]
        [Display(Name = "Room")]
        public string room { get; set; }

        [Display(Name = "Time")]
        public int time { get; set; }
        
        [Display(Name = "Available")]
        public bool available { get; set; }
    }
}