using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DirectListt.Models
{
    public class Banner
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(250)]
        public string Image { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }


        [MaxLength(50)]
        public string Title { get; set; }

        [MaxLength(150)]
        public string SubTitle { get; set; }

        [MaxLength(50)]
        public string Page { get; set; }
    }
}
