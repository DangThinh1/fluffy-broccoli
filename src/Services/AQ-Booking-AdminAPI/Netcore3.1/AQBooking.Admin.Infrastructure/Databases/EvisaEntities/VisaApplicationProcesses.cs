﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace AQBooking.Admin.Infrastructure.Databases.EvisaEntities
{
    public partial class VisaApplicationProcesses
    {
        public long Id { get; set; }
        public long ApplicationFid { get; set; }
        public int AssignMerchantFid { get; set; }
        public Guid AssignedBy { get; set; }
        public DateTime AssignedDate { get; set; }
        public string AssignedRemark { get; set; }
        public DateTime? EndProcessOn { get; set; }
        public string EndProcessRemark { get; set; }
        public bool Deleted { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid LastModifiedBy { get; set; }
        public DateTime LastModifiedDate { get; set; }
    }
}