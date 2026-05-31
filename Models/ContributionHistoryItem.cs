using System;
using System.Collections.Generic;
using System.Text;

namespace ImfuyoSync.Models
{
    public class ContributionHistoryItem
    {
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public bool IsReimbursement { get; set; }
    }

}
