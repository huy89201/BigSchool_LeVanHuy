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
        private string place;
        private string date;
        private string time;
        private byte category;
        private IEnumerable<Category> categories;

        [Required]
        public string Place { get => place; set => place = value; }
        [Required]
        [FutureDate]
        public string Date { get => date; set => date = value; }
        [Required]
        [ValidTime]
        public string Time { get => time; set => time = value; }
        [Required]
        public byte Category { get => category; set => category = value; }
        public IEnumerable<Category> Categories { get => categories; set => categories = value; }

        public  DateTime GetDateTime()
        {
            return DateTime.Parse(string.Format("{0} {1}", Date, Time));
        }
        

    }
}