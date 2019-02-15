using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LabeCommerce.Models
{
    public class Product
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}