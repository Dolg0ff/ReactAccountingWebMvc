using ReactAccountingWebMvc.Domain;
using ReactAccountingWebMvc.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReactAccountingWebMvc.Infrastructure.Implementations
{
    public class TwoModelsService : ITwoModelsService
    {

        private ITwoModelsRepository twoModelsRepository;
        public TwoModelsService(ITwoModelsRepository twoModelsRepository)
        {
            this.twoModelsRepository = twoModelsRepository;
        }

        public IEnumerable<Account> AllAccounts()
        {
            return this.twoModelsRepository.AllAccounts();
        }

        public IEnumerable<Domain.Models.Transaction> AllTransactions()
        {
            return this.twoModelsRepository.AllTransactions();
        }
    }
}
    