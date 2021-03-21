using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TaskElreefelmasry2.Models
{
    public class Booklets
    {
        [Key]
        public int BookletID { get; set; }
        public Activity Activity { get; set; } = Activity.other;
        public Status BookletStatus { get; set; } = Status.Available;

        public Booklets()
        {
            BookletSales = new HashSet<BookletSales>();
           
        }
        public virtual ICollection<BookletSales>  BookletSales { get; set; }
    }
    public enum Activity
    {
        [Display(Name ="Commercial")]
        commercial=0,
        [Display(Name = "Agricultural")]
        Agricultural =1,
        [Display(Name = "other")]
        other =2
    }
    public enum Status
    {
        [Display(Name = "Available")]
        Available =3,
        [Display(Name = "sold")]
        sold =4
    }
}