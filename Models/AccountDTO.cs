using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RulesApi.Models
{
    public class AccountDTO
    {
        public int AccountId { get; set; }
        public int CustomerId { get; set; }
        public int AccountType { get; set; }
        public float Balance { get; set; }
    }
}
