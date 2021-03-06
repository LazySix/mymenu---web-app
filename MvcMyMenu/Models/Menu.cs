﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMyMenu.Models
{
    public class Menu
    {
        public int MenuId { get; set; }
        public int RestaurantId { get; set; }
      
        public string Name { get; set; }
        public decimal Price { get; set; }
     

        public Restaurant Restaurant { get; set; }
        
    }
}