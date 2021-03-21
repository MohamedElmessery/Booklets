using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using TaskElreefelmasry2.CustomValidation;

namespace TaskElreefelmasry2.Models
{
    public class BookletSales
    {
        [Key]
        public int Serial { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:D}",ApplyFormatInEditMode =false)]
        [LessThanCurrent]
        public DateTime Date { get; set;}
        public string CustomerID { get; set; }
        public string CustomerName { get; set; }
        [ForeignKey("Booklets")]
        public int BookletID { get; set; }
        public virtual Booklets  Booklets { get; set; }

    }
}