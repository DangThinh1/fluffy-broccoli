﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace AQBooking.Admin.Infrastructure.Databases.EvisaEntities
{
    public partial class CountryEmbassyInformations
    {
        public int Id { get; set; }
        public string EmbassyCountry { get; set; }
        public string CountryLocation { get; set; }
        public string EmbassyName { get; set; }
        public string EmbassyAddress { get; set; }
        public string Email { get; set; }
        public string WebsiteUrl { get; set; }
        public string HotLine { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid LastModifiedBy { get; set; }
        public DateTime LastModifiedDate { get; set; }
    }
}