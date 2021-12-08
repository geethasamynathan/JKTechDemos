﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Validationdemo2.Common
{
    public class DateRangeAttribute:RangeAttribute
    {
        public DateRangeAttribute(string minimumValue)
            :base(typeof(DateTime),minimumValue,DateTime.Now.ToShortDateString())
        {

        }
    }
}