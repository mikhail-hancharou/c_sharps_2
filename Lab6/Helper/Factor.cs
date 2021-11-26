using System;
using System.Collections.Generic;
using System.Text;
using Lab6.Entities;

namespace Lab6.Helper
{
    public static class Factor
    {
        public static double GetFactor(Tariffs tariff)
        {
            return tariff switch
            {
                Tariffs.ECONOM => 1,
                Tariffs.STANDART => 1.5,
                Tariffs.PREMIUM => 2,
                _ => throw new ArgumentNullException("non-valid tariff")
            };
        }
    }
}
