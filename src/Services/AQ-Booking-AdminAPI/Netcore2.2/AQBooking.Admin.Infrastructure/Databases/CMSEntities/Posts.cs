﻿using System;
using System.Collections.Generic;

namespace AQBooking.Admin.Infrastructure.Databases.CMSEntities
{
    public partial class Posts
    {
        public long Id { get; set; }
        public string UniqueId { get; set; }
        public int PostCategoryFid { get; set; }
        public string PostCategoryResKey { get; set; }
        public string DefaultTitle { get; set; }
        public short TimeToRead { get; set; }
        public bool Deleted { get; set; }
        public bool IsActivated { get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public Guid? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
    }
}
