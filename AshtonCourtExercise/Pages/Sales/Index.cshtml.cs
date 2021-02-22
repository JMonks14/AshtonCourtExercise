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
    public class IndexModel : PageModel
    {
        private readonly AshtonCourtExercise.Data.AshtonCourtExerciseContext _context;

        public IndexModel(AshtonCourtExercise.Data.AshtonCourtExerciseContext context)
        {
            _context = context;
        }

        public IList<CarSale> CarSale { get;set; }

        public IList<Car> Cars { get; set; }

        public async Task OnGetAsync()
        {
            CarSale = await _context.Sales.ToListAsync();
            Cars = await _context.Cars.ToListAsync();
        }

        public Car FindCarById(int id)
        {
            Car returned = null;
            foreach(Car car in Cars)
            {
                if (id == car.Id) returned = car;
            }
            return returned;
        }
    }
}
