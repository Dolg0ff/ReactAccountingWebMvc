using System;
using System.Collections.Generic;
using System.Text;
using ReactAccountingWebMvc.Domain.Models;

namespace ReactAccountingWebMvc.Domain.Interfaces
{
    public interface IAccountRepository
    {
        void Add(Account account);
        void Delete(Guid id);
        Account Find(Guid id);
        void Update(Account account);
        IEnumerable<Account> All();
    }
}
