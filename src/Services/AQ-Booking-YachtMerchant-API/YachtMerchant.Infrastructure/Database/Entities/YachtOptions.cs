﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace YachtMerchant.Infrastructure.Database.Entities
{
    public partial class YachtOptions
    {
        public int YachtId { get; set; }
        public string YachtUniqueId { get; set; }
        public bool IsExclusiveYacht { get; set; }
        public bool AutoCancelledPromotion { get; set; }
        public double CancelledPromotionPercent { get; set; }
        public bool HaveAdditionalServices { get; set; }
        public bool ActiveForTour { get; set; }
        public Guid? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
    }
}