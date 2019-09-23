using ReactAccountingWebMvc.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using ReactAccountingWebMvc.Domain.Models;
using ReactAccountingWebMvc.Domain;
using ReactAccountingWebMvc.Domain.Interfaces;

namespace ReactAccountingWebMvc.Domain.Implementations
{
    public class TransactionRepository : ITransactionRepository
    {

        private readonly ApplicationContext db;
        public TransactionRepository(ApplicationContext context)
        {
            db = context;
        }

        public void Add(Transaction transaction)
        {
            var fromAcc = db.Accounts.Find(transaction.AccountId);
            var toAcc = db.Accounts.Find(transaction.ToAccountId);
            transaction.FromAccountName = db.Accounts.Find(transaction.AccountId).Name;
            switch (transaction.Type)
            {
                case TransactionType.Income:
                    if (transaction.Count != 0)
                    {
                        fromAcc.Balance += transaction.Count;
                        if (toAcc != null)
                        {
                            toAcc.Balance -= transaction.Count;
                        }
                    }
                    //else
                    //{

                    //}
                    break;
                case TransactionType.Outcome:
                    fromAcc.Balance -= transaction.Count;
                    toAcc.Balance += transaction.Count;
                    break;
            }
            db.Transactions.Add(transaction);
            db.SaveChanges();
            db.Dispose();
        }

        public IEnumerable<Transaction> All()
        {
            return db.Transactions.ToList();
        }

        public IEnumerable<Account> AllAccounts()
        {
            return db.Accounts.ToList();
        }

        public Transaction Find(Guid id)
        {
            var transaction = db.Transactions.Find(id);
            db.Dispose();
            return transaction;
        }
    }
}
