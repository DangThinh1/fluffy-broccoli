﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AQBooking.YachtPortal.Infrastructure.Entities
{
    public partial class YachtAttributes
    {
        public virtual List<YachtAttributeValues> AttributeValues { get; set; }
    }
}
