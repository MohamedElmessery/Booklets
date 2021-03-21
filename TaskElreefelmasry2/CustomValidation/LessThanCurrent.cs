using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TaskElreefelmasry2.CustomValidation
{
    public class LessThanCurrent:ValidationAttribute
    {
        public LessThanCurrent():base("{0} Date should less than cuurent data")
        {

        }
        public override bool IsValid(object value)
        {
            DateTime propValue = Convert.ToDateTime(value);
            if (propValue >= DateTime.Now)
                return true;
            else
                return false;
        }
    }
}