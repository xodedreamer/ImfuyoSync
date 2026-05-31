using System;
using System.Collections.Generic;
using System.Text;

namespace ImfuyoSync.Models
{
    public class Contributor
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }

        public decimal TotalContributed { get; set; }
        public decimal TotalReimbursed { get; set; }

        public decimal Balance => TotalContributed - TotalReimbursed;
    }

}
