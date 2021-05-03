using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Adoptex.Data;
using Adoptex.Models;
using Adoptex.Utility;
using Microsoft.AspNetCore.Authorization;

namespace Adoptex.Pages.DoAdopcji
{
    [Authorize(Roles =SD.AdminEndUser)]
    public class DeleteModel : PageModel
    {
     
        private readonly Adoptex.Data.ApplicationDbContext _context;

        public DeleteModel(Adoptex.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Animal_Info = await _context.Animal_Info.FindAsync(id);

            if (Animal_Info != null)
            {
                _context.Animal_Info.Remove(Animal_Info);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
