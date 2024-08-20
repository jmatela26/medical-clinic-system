using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MedicalSystem
{
    class Medicine
    {
        public double totalCost;
       
        public double getTotalCost(double cost, double quantity)
        {
            return totalCost = cost * quantity;
        }
    }
}