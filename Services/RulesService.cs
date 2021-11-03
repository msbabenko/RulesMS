using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RulesApi.Services
{
    public class RulesService : IRules
    {
        private const float _MAB = 5000; //minimum average balance (MAB)

        public string evaluateMinBal(int accountId, float balance)
        {
            switch (balance)
            {
                case > _MAB:
                    return "allowed";
                    break;
                case > 0:
                case < _MAB:
                    return "denied";
                    break;
                default:
                    return "N/A";
                    break;
            }
        }

        public float getServiceCharges(float balance)
        {
            float withServiceCharge = balance;

            //Metro/Urban/Semi-Urban/Rural locations :
            //Rs. 100 + 5 % of the shortfall in required MAB

            if (balance < _MAB)
                withServiceCharge += 100 + ( _MAB - balance)* 0.05f;
            
            return withServiceCharge;
        }
    }
}
