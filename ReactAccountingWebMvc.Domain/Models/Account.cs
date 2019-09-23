using ReactAccountingWebMvc.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReactAccountingWebMvc.Domain
{
    public class Account
    {
        public string Name { get; set; }
        public Guid Id { get; set; }
        public AccountType Type { get; set; }
        public DateTime Date { get; set; }
        public double Balance { get; set; }
        public String UserId { get; set; }
    }
}