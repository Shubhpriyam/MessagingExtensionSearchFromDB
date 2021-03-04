using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProAPI.Dto
{
    public class CommandCreateDto
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Dept { get; set; }

        [Required]
        public string Domain { get; set; }
    }
}
