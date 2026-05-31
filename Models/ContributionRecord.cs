using System;
using System.Collections.Generic;
using System.Text;

namespace ImfuyoSync.Models
{
    public class ContributionRecord
    {
        public string Id { get; set; }
        public string ContributorId { get; set; }

        public decimal Amount { get; set; }
        public bool IsReimbursement { get; set; }

        public DateTime Date { get; set; }
    }

}
