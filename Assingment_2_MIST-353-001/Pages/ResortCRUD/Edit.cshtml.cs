using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Assingment_2_MIST_353_001.Data;
using GeoSnowAPI.Entities;

namespace Assingment_2_MIST_353_001.Pages.ResortCRUD
{
    public class EditModel : PageModel
    {
        private readonly Assingment_2_MIST_353_001.Data.DbContextClass _context;

        public EditModel(Assingment_2_MIST_353_001.Data.DbContextClass context)
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

            var resort =  await _context.RESORT.FirstOrDefaultAsync(m => m.ResortID == id);
            if (resort == null)
            {
                return NotFound();
            }
            Resort = resort;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Resort).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ResortExists(Resort.ResortID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ResortExists(int id)
        {
            return _context.RESORT.Any(e => e.ResortID == id);
        }
    }
}
