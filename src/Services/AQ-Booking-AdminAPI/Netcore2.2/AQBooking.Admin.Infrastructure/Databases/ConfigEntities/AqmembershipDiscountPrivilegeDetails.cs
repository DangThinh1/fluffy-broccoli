﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace AQBooking.Admin.Infrastructure.Databases.ConfigEntities
{
    public partial class AqmembershipDiscountPrivilegeDetails
    {
        public long Id { get; set; }
        public int PrivilegeFid { get; set; }
        public string BookingDomainUniqueId { get; set; }
        public int BookingDomainFid { get; set; }
        public string BookingDomainName { get; set; }
        public double DiscountPercent { get; set; }
        public string Remark { get; set; }
        public Guid LastModifiedBy { get; set; }
        public DateTime LastModifiedDate { get; set; }
    }
}