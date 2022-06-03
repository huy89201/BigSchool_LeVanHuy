using BigSchool_LeVanHuy.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BigSchool_LeVanHuy.ViewModels
{
    public class CourseViewModel
    {   
        [Required]
        private string time;
        [Required]
        private byte category;
        [Required]
        private string place;
        [Required]
        [FutureDate]
        private string date;
        private IEnumerable<Category> categories;

        public string Place { get => place; set => place = value; }
        public string Date { get => date; set => date = value; }
        public string Time { get => time; set => time = value; }
        public byte Category { get => category; set => category = value; }
        public IEnumerable<Category> Categories { get => categories; set => categories = value; }

        public  DateTime GetDateTime()
        {
            return DateTime.Parse(string.Format("{0} {1}", Date, Time));
        }
        

    }
}