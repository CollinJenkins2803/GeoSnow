using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Assingment_2_MIST_353_001.Data;
using GeoSnowAPI.Entities;

namespace Assingment_2_MIST_353_001.Pages.ResortCRUD
{
    public class DeleteModel : PageModel
    {
        private readonly Assingment_2_MIST_353_001.Data.DbContextClass _context;

        public DeleteModel(Assingment_2_MIST_353_001.Data.DbContextClass context)
        {
            _context = context;
        }

        [BindProperty]
        public Resort Resort { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var resort = await _context.RESORT.FirstOrDefaultAsync(m => m.ResortID == id);

            if (resort == null)
            {
                return NotFound();
            }
            else
            {
                Resort = resort;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var resort = await _context.RESORT.FindAsync(id);
            if (resort != null)
            {
                Resort = resort;
                _context.RESORT.Remove(Resort);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
