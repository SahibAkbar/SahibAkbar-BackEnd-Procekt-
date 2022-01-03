using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DirectListt.Models
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }


        [MaxLength(50)]
        public string FirstName { get; set; }

        [MaxLength(50)]
        public string LastName { get; set; }

        [MaxLength(50), Required]
        public string Email { get; set; }

        [MaxLength(100)]
        public string Subject { get; set; }

        [Column(TypeName ="ntext")]
        public string Message { get; set; }

        public DateTime CretedDate { get; set; }
    }
}
