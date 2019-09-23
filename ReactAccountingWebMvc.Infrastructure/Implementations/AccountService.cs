using ReactAccountingWebMvc.Domain;
using ReactAccountingWebMvc.Domain.Interfaces;
using ReactAccountingWebMvc.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;


namespace Accounting.Infrastructure.Implementations
{
    public class AccountService : IAccountService
    {
        private IAccountRepository accountRepository;
        public AccountService(IAccountRepository accountRepository)
        {
            this.accountRepository = accountRepository;
        }

        public void Add(Account account)
        {
            if (account == null)
            {
                return;
            }
            account.Date = DateTime.Now;
            this.accountRepository.Add(account);
        }

        public IEnumerable<Account> All()
        {
            return this.accountRepository.All();
        }

        public void Delete(Guid id)
        {
            if (id == null)
            {
                return;
            }
            this.accountRepository.Delete(id);
        }

        public Account Find(Guid id)
        {
            if (id == null)
            {
                return null;
            }
            return this.accountRepository.Find(id);
        }

        public void Update(Account account)
        {
            if (account == null)
            {
                return;
            }
            this.accountRepository.Update(account);
        }
    }
}
