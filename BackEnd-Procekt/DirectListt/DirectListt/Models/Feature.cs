using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DirectListt.Models
{
    public class Feature
    {
        public int Id { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        public List<RestaurantToFetaure> RestaurantToFetaures { get; set; }
    }
}
