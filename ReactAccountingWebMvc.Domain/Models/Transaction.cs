using ReactAccountingWebMvc.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReactAccountingWebMvc.Domain.Models
{
    public class Transaction
    {
        public Guid Id { get; set; }
        public double Count { get; set; }
        public TransactionType Type { get; set; }
        public DateTime Date { get; set; }
        public string Comment { get; set; }
        public Guid? AccountId { get; set; }
        //переводы
        public string FromAccountName { get; set; }
        public Guid? FromAccountId { get; set; }
        public string ToAccountName { get; set; }
        public Guid? ToAccountId { get; set; }
        public Account Account { get; set; }
    }
}
