using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RulesApi.Models
{
    public class Rule
    {
        public int StatusId { get; set; }
        public float ServiceCharge { get; set; }
        public float MinBalance { get; set; }
    }
}
