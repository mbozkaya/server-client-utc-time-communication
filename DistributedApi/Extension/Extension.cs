using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace DistributedApi.Extension
{
    public static class Extension
    {
        // 1 Jan 1970 is begin of UNIX Time
        public static int LocalizeTimeStamp(this DateTime value) => (Int32)(value.ToUniversalTime().Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
    }
}
