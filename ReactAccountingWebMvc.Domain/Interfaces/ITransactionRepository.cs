using ReactAccountingWebMvc.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;


namespace ReactAccountingWebMvc.Domain.Interfaces
{
    public interface ITransactionRepository
    {
        void Add(Transaction transaction);
        Transaction Find(Guid id);
        IEnumerable<Transaction> All();
        IEnumerable<Account> AllAccounts();
    }
}
