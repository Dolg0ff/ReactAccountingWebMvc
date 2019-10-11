using ReactAccountingWebMvc.Domain;
using ReactAccountingWebMvc.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;


namespace ReactAccountingWebMvc.Infrastructure.Implementations
{
    public class TransactionService : ITransactionService
    {
        private ITransactionRepository transactionRepository;
        public TransactionService(ITransactionRepository transactionRepository)
        {
            this.transactionRepository = transactionRepository;
        }

        public void Add(Domain.Models.Transaction transaction)
        {
            if (transaction == null)
            {
                return;
            }
            transaction.Date = DateTime.Now;
            this.transactionRepository.Add(transaction);
        }

        public IEnumerable<Domain.Models.Transaction> All()
        {
            return this.transactionRepository.All();
        }

        public IEnumerable<Account> AllAccounts()
        {
            return this.transactionRepository.AllAccounts();
        }

        public Domain.Models.Transaction Find(Guid id)
        {
            if (id == null)
            {
                return null;
            }
            return this.transactionRepository.Find(id);
        }
    }
}
