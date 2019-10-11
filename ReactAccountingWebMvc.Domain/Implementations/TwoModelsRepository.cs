using ReactAccountingWebMvc.Domain.Interfaces;
using ReactAccountingWebMvc.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReactAccountingWebMvc.Domain.Implementations
{
    public class TwoModelsRepository : ITwoModelsRepository
    {
        private readonly ApplicationContext db;
        public TwoModelsRepository(ApplicationContext context)
        {
            db = context;
        }

        public IEnumerable<Account> AllAccounts()
        {
            return db.Accounts.ToList();
        }

        public IEnumerable<Transaction> AllTransactions()
        {
            return db.Transactions.ToList();
        }
    }
}
