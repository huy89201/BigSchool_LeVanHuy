using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BigSchool_LeVanHuy.Models
{
    public class Category
    {
        private byte id;

        [Required]
        [StringLength(255)]
        private string name;

        public byte Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
    }
}