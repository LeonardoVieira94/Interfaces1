﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces1.Services
{
    internal class BrazilTaxService : ITaxService
    {

        public double Tax(double amount)
        {
            if (amount <= 100.00)
            {
                return amount * 0.20;
            }
            else
            {
                return (amount * 0.15);
            }
        }

    }
}
