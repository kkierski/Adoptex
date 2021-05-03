using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Adoptex.Models
{
    public class Animal_Info
    {
        public int Id { get; set; }

        [Required]
        public string Imie { get; set; }

        [Required]
        public string Wiek { get; set; }

        [Required]
        public string Telefon { get; set; }

        [Required]
        public string Opis { get; set; }
    }
}
