
using ReactAccountingWebMvc.Domain;
using ReactAccountingWebMvc.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReactAccountingWebMvc.Infrastructure
{
    public interface ITransactionService
    {
        void Add(Transaction transaction);
        Transaction Find(Guid id);
        IEnumerable<Transaction> All();
        IEnumerable<Account> AllAccounts();
    }
}
