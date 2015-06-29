using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcMyMenu.Models
{
    public partial class Restaurant
    {
        public int RestaurantId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Menu> Menus { get; set; }      
    }
}