﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace AQBooking.Admin.Infrastructure.Databases.HotelEntities
{
    public partial class HotelAttributeValues
    {
        public long Id { get; set; }
        public int HotelFid { get; set; }
        public int? AttributeCategoryFid { get; set; }
        public int AttributeFid { get; set; }
        public string AttributeValue { get; set; }
        public bool BasedAffective { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public Guid LastModifiedBy { get; set; }
        public DateTime LastModifiedDate { get; set; }
    }
}