using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationPOS.Models
{
    public class ProductViewModel
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string Description { set; get; }
        public float Price  { set; get; }
    }
}