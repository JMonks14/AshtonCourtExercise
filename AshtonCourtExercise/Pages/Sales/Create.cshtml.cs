using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using AshtonCourtExercise.Data;
using AshtonCourtExercise.Models;

namespace AshtonCourtExercise.Pages.Sales
{
    public class CreateModel : PageModel
    {
        private readonly AshtonCourtExercise.Data.AshtonCourtExerciseContext _context;

        public CreateModel(AshtonCourtExercise.Data.AshtonCourtExerciseContext context)
        {
            _context = context;
        }

        public List<SelectListItem> Options { get; set; }

        public IActionResult OnGet()
        {
            Options = _context.Cars.Select(a =>
                                   new SelectListItem
                                   {
                                       Value = $"{ a.Id}",
                                       Text = $"{ a.Year } {a.Manufacturer} {a.ModelName}"
                                   }).ToList();
            return Page();
        }       

        [BindProperty]
        public CarSale CarSale { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Sales.Add(CarSale);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
