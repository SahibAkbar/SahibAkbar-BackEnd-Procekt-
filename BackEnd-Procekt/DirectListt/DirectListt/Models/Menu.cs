using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DirectListt.Models
{
    public class Menu
    {
        public int Id { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(500)]
        public string Ingredient { get; set; }

        public List<RestaurantToMenu> RestaurantToMenus { get; set; }
    }
}
