using System;
using System.Collections.Generic;
using System.Text;

namespace ReactAccountingWebMvc.Domain.Models
{
    //this class is necessary for further use of two entities in one view
    public class TwoModels
    {
        public Guid Id { get; set; }
        public Account Account { get; set; }
        public Transaction Transaction { get; set; }
    }
}
