using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Adoptex.Models;
using Adoptex.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Adoptex.Utility;
using Microsoft.AspNetCore.Authorization;

namespace Adoptex.Pages.DoAdopcji
{
    [Authorize(Roles =SD.AdminEndUser)]
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        [BindProperty]
        public Animal_Info Animal_Info { get; set; }

        public CreateModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        public async Task <IActionResult> OnPostAsync(Animal_Info animal_Info)
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }

            _db.Animal_Info.Add(animal_Info);
            await _db.SaveChangesAsync();

            return RedirectToPage("Index");
        }
    }
}