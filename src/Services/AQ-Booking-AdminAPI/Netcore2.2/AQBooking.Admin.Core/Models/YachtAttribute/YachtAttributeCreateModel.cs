﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AQBooking.Admin.Core.Models.YachtAttribute
{
    public class YachtAttributeCreateModel
    {
        public int Id { get; set; }
        public string UniqueId { get; set; }
        public int? AttributeCategoryFid { get; set; }
        public string AttributeName { get; set; }
        public string IconCssClass { get; set; }
        public string ResourceKey { get; set; }
        public string Remarks { get; set; }
        public bool IsDefault { get; set; }
        public double? OrderBy { get; set; }
    }
}
