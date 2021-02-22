using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AshtonCourtExercise.Data;
using AshtonCourtExercise.Models;

namespace AshtonCourtExercise.Pages.Cars
{
    public class IndexModel : PageModel
    {
        private readonly AshtonCourtExercise.Data.AshtonCourtExerciseContext _context;

        public IndexModel(AshtonCourtExercise.Data.AshtonCourtExerciseContext context)
        {
            _context = context;
        }

        public IList<Car> Car { get;set; }

        public async Task OnGetAsync()
        {
            Car = await _context.Cars.ToListAsync();
        }
    }
}
