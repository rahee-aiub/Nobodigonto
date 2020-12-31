using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestCoreApp.Models
{
    public class Member
    {
        public int Id { get; set; }
        public int MemberId { get; set; }
        public string Name { get; set; }
        public int AdminId { get; set; }
        public Admin Admin { get; set; }
        public decimal Amount { get; set; }
    }
}
