using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AshtonCourtExercise.Data;
using AshtonCourtExercise.Models;

namespace AshtonCourtExercise.Pages.Sales
{
    public class DetailsModel : PageModel
    {
        private readonly AshtonCourtExercise.Data.AshtonCourtExerciseContext _context;

        public DetailsModel(AshtonCourtExercise.Data.AshtonCourtExerciseContext context)
        {
            _context = context;
        }

        public CarSale CarSale { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            CarSale = await _context.Sales.FirstOrDefaultAsync(m => m.Id == id);

            if (CarSale == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
