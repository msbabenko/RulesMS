using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RulesApi.Services
{
    interface IRules
    {
       string evaluateMinBal(int accountId, float balance);
       float getServiceCharges(float balance);

    }
}
