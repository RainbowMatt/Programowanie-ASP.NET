using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Programowanie_ASP.NET.Models
{
    public class Travel
    {
        [HiddenInput]
        public int Id { get; set; }
        [Required(ErrorMessage = "Proszę podać nazwe!")]
        public string Name { get; set; }
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }
        public string StartingLocation { get; set; }
        public string EndingLocation { get; set; }
        public List<string> Participants { get; set; }
        public string Guide { get; set; }
    }
}
