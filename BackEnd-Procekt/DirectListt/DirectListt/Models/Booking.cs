using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DirectListt.Models
{
    public class Booking
    {
        public int Id { get; set; }

        [MaxLength(50)]
        public string ReserveName { get; set; }
        public DateTime ReserveDate { get; set; }

        public byte PersonCount { get; set; }

        [ForeignKey("Restaurant")]
        public int RestaurantId { get; set; }
        public Restaurant Restaurant { get; set; }
    }
}
