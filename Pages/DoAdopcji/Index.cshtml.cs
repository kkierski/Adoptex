using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Adoptex.Data;
using Adoptex.Models;
using Adoptex.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Adoptex.Pages.DoAdopcji
{
  
    public class IndexModel : PageModel
    {

        private readonly ApplicationDbContext _db;

        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public IList<Animal_Info> Animal_info { get; set; }

        public async Task<IActionResult> OnGet()
        {
            Animal_info =  await _db.Animal_Info.ToListAsync();
            return Page();
        }
    }
}