﻿using System;
using System.Collections.Generic;

namespace YachtMerchant.Infrastructure.Entities
{
    public partial class YachtPricingPlanInformations
    {
        public long Id { get; set; }
        public int PricingPlanFid { get; set; }
        public int LanguageFid { get; set; }
        public string PriceIncludedInfo { get; set; }
        public string PriceNotIncludedInfo { get; set; }
        public string Remark { get; set; }
        public bool Deleted { get; set; }
        public bool IsActivated { get; set; }
        public Guid LastModifiedBy { get; set; }
        public DateTime LastModifiedDate { get; set; }
    }
}