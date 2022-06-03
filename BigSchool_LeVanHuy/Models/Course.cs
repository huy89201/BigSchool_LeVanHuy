using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BigSchool_LeVanHuy.Models
{
    public class Course
    {
        private int id;
        private ApplicationUser lecturer;
        [Required]
        private string lecturerId;
        [Required]
        [StringLength(255)]
        private string place;
        private DateTime dateTime;
        private Category category;
        [Required]
        private byte categoryId;

        public int Id { get => id; set => id = value; }
        public ApplicationUser Lecturer { get => lecturer; set => lecturer = value; }
        public string LecturerId { get => lecturerId; set => lecturerId = value; }
        public string Place { get => place; set => place = value; }
        public DateTime DateTime { get => dateTime; set => dateTime = value; }
        public Category Category { get => category; set => category = value; }
        public byte CategoryId { get => categoryId; set => categoryId = value; }
    }
}