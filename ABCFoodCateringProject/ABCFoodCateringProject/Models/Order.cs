using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ABCFoodCateringProject.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        [Required]
        public string FoodDescription { get; set; }
        public string DeliveryAddress { get; set; }
        public DateTime DeliveryDT { get; set; }
        public int Quantity { get; set; }
        public string OrderBy { get; set; }
        public DateTime OrderDate { get; set; }
        public string CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
