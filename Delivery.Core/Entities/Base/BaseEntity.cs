﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Core.Entities.Base
{
    public abstract class BaseEntity<TId>
    {
        public virtual TId Id { get; protected set; }
    }
}
