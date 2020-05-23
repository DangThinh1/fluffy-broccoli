﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace YachtMerchant.Core.Models.YachtCharterings
{
    public class YachtCharteringsUpdateModel: YachtCharteringsCreateModel
    {
        [Required]
        public long CharteringFid { get; set; }
    }
}
