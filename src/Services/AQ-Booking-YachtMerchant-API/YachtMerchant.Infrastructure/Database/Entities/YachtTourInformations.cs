﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace YachtMerchant.Infrastructure.Database.Entities
{
    public partial class YachtTourInformations
    {
        public long Id { get; set; }
        public int TourFid { get; set; }
        public string UniqueId { get; set; }
        public int TourInformationTypeFid { get; set; }
        public string TourInformationTypeResKey { get; set; }
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