﻿using System;
using System.Collections.Generic;
using System.Text;

namespace YachtMerchant.Core.Models.YachtCharterings
{
    public class GetTotalAmountReservationOfMerchantWithItemTypeModel
    {
        public int MerchantId { get; set; }
        public int ReservationItemType { get; set; }
        public string EffectiveStartDate { get; set; }
    }
}
