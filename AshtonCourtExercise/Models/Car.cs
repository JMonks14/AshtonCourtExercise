using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AshtonCourtExercise.Models
{
    public class Car
    {
        public int Id { get; set; }

        public string ModelName { get; set; }
        public string Manufacturer { get; set; }
        public string ManufacturerCountry { get; set; }
        public string Description { get; set; }
        public int MilesDriven { get; set; }
        public int Year { get; set; }

        public string toString()
        {
            return Year + " " + Manufacturer + " " + ModelName;
        }
    }
}
