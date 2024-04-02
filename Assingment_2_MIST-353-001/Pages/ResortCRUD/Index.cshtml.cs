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
    public class IndexModel : PageModel
    {
        private readonly Assingment_2_MIST_353_001.Data.DbContextClass _context;

        public IndexModel(Assingment_2_MIST_353_001.Data.DbContextClass context)
        {
            _context = context;
        }

        public IList<Resort> Resort { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Resort = await _context.RESORT.ToListAsync();
        }
    }
}
