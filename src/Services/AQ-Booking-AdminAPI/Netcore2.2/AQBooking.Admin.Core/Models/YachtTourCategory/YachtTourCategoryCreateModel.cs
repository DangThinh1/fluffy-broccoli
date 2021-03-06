﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AQBooking.Admin.Core.Models.YachtTourCategory
{
    public class YachtTourCategoryCreateModel
    {
        public int Id { get; set; }
        public string DefaultName { get; set; }
        public string ResourceKey { get; set; }
        public int LanguageFID { get; set; }
        public string Remark { get; set; }
        public DateTime? ActivatedDate { get; set; }
        public DateTime EffectiveDate { get; set; }
        public bool IsActivated { get; set; }
        public int FileTypeFid { get; set; }
        public int FileStreamFid { get; set; }
        public bool Deleted { get; set; }
        public double? OrderBy { get; set; }
    }
}
