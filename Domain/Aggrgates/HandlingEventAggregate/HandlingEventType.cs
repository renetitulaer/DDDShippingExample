﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Aggrgates.HandlingIncidentAggregate
{
    public enum HandlingEventType
    {
        Load,
        Unload,
        Receive,
        Claim,
        Customs
    }
}
