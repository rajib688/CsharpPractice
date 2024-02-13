using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchStatement
{
    public class Bank
    {
        public string Name { get; set; }
        public BankBranchStatus Status { get; set; }
    }

    public enum BankBranchStatus
    {
        Open,
        Closed,
        VIPCustomersOnly
    }
}
