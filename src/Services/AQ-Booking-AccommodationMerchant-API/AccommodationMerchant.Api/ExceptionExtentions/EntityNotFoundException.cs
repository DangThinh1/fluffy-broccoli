﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AccommodationMerchant.Api.ExceptionExtentions
{
    public class EntityNotFoundException : Exception
    {
        public EntityNotFoundException(string name, object key)
        : base($"Entity '{name}' ({key}) was not found.")
        {
        }
    }
}
