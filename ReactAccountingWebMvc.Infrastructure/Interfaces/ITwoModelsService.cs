using ReactAccountingWebMvc.Domain;
using ReactAccountingWebMvc.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;


namespace ReactAccountingWebMvc.Infrastructure
{
    public interface ITwoModelsService
    {
        IEnumerable<Account> AllAccounts();
        IEnumerable<Transaction> AllTransactions();
    }
}
