﻿using System;
using System.Collections.Generic;

namespace AccommodationMerchant.Core.Models.HotelAttributeValues
{
    public class HotelAttributeValueUpdateRangeModel
    {
        public int HotelFid { get; set; }
        public List<int> ListAttributeId { get; set; }
        public List<string> ListAttributeValue { get; set; }
        public int? AttributeCategoryFid { get; set; }
    }
}