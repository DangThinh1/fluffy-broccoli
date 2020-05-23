﻿using System;
using System.Collections.Generic;

namespace Accommodation.Infrastructure.Databases.Entities
{
    public partial class HotelInformations
    {
        public int Id { get; set; }
        public int HotelFid { get; set; }
        public string UniqueId { get; set; }
        public string DefaultTitle { get; set; }
        public string Remark { get; set; }
        public bool Deleted { get; set; }
        public bool IsActivated { get; set; }
        public DateTime? ActivatedDate { get; set; }
        public Guid? ActivatedBy { get; set; }
        public Guid LastModifiedBy { get; set; }
        public DateTime LastModifiedDate { get; set; }
    }
}