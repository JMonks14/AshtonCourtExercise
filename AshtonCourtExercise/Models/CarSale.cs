using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AshtonCourtExercise.Models
{
    public class CarSale
    {
        public int Id { get; set; }

        public string BuyerName { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal SalePrice { get; set; }

        public DateTime SaleDate { get; set; }

        public int CarId { get; set; }

        public Car Car { get; set; }
    }
}
