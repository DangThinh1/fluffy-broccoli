﻿using System;
using System.Collections.Generic;

namespace AQBooking.YachtPortal.Infrastructure.Entities
{
    public partial class YachtMerchantProductVendors
    {
        public int Id { get; set; }
        public string UniqueId { get; set; }
        public int MerchantFid { get; set; }
        public int ProductCategoryFid { get; set; }
        public string ProductCategoryResKey { get; set; }
        public string Name { get; set; }
        public int VendorTypeFid { get; set; }
        public string VendorTypeResKey { get; set; }
        public string ContactNo { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Remark { get; set; }
        public bool Deleted { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid LastModifiedBy { get; set; }
        public DateTime LastModifiedDate { get; set; }
    }
}