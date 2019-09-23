using ReactAccountingWebMvc.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReactAccountingWebMvc.Infrastructure.Interfaces
{
    public interface IAccountService
    {
        void Add(Account account);
        void Delete(Guid id);
        Account Find(Guid id);
        void Update(Account account);
        IEnumerable<Account> All();
    }
}
