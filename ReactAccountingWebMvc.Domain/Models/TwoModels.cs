using System;
using System.Collections.Generic;
using System.Text;

namespace ReactAccountingWebMvc.Domain.Models
{
    public class TwoModels
    {
        public Guid Id { get; set; }
        public Account Account { get; set; }
        public Transaction Transaction { get; set; }
    }
}
