using ReactAccountingWebMvc.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReactAccountingWebMvc.Domain.Interfaces
{
    public interface ITwoModelsRepository
    {
        IEnumerable<Account> AllAccounts();
        IEnumerable<Transaction> AllTransactions();
    }
}
