using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Adoptex.Data;
using Adoptex.Models;

namespace Adoptex.Pages.DoAdopcji
{
    public class DetailsModel : PageModel
    {
        private readonly Adoptex.Data.ApplicationDbContext _context;

        public DetailsModel(Adoptex.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Animal_Info Animal_Info { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Animal_Info = await _context.Animal_Info.FirstOrDefaultAsync(m => m.Id == id);

            if (Animal_Info == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
