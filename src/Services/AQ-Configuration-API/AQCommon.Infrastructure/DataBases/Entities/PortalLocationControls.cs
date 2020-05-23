﻿using System;
using System.Collections.Generic;

namespace AQConfigurations.Infrastructure.Databases.Entities
{
    public partial class PortalLocationControls
    {
        public int Id { get; set; }
        public string PortalUniqueId { get; set; }
        public int DomainPortalFid { get; set; }
        public string CountryName { get; set; }
        public int CountryCode { get; set; }
        public string CityName { get; set; }
        public int CityCode { get; set; }
        public string CssClass { get; set; }
        public int FileStreamFid { get; set; }
        public bool Deleted { get; set; }
        public bool IsActive { get; set; }
        public bool IsExclusive { get; set; }
        public double OrderBy { get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public Guid? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
    }
}
