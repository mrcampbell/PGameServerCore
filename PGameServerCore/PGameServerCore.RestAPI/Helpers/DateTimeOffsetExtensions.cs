using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PGameServerCore.RestAPI.Helpers
{
    public static class DateTimeOffsetExtensions
    {
        public static int GetDaysSince(this DateTimeOffset dateTimeOffset)
        {
            var currentDate = DateTime.Now;
            int numDays = currentDate.Day - dateTimeOffset.Day;

            if (currentDate < dateTimeOffset.AddDays(numDays))
            {
                numDays--;
            }

            return numDays;
        }
    }
}
