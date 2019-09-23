using System;
using System.Collections.Generic;
using System.Text;
using ReactAccountingWebMvc.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.Linq;
using ReactAccountingWebMvc.Domain.Interfaces;


namespace ReactAccountingWebMvc.Domain.Implementations
{
    public class AccountRepository : IAccountRepository
    {
        private readonly ApplicationContext db;
        public AccountRepository(ApplicationContext context)
        {
            db = context;
        }

        public void Add(Account account)
        {
            var acc = db.Users.Find(account.UserId);
            db.Accounts.Add(account);
            db.SaveChanges();
            db.Dispose();
        }

        public IEnumerable<Account> All()
        {
            return db.Accounts.ToList();
        }

        public void Delete(Guid id)
        {
            var account = db.Accounts.Find(id);
            db.Accounts.Remove(account);
            db.SaveChanges();
            db.Dispose();
        }

        public Account Find(Guid id)
        {
            var account = db.Accounts.Find(id);
            db.Dispose();
            return account;
        }

        public void Update(Account account)
        {
            var acc = db.Accounts.Find(account.Id);
            acc.Id = account.Id;
            db.SaveChanges();
            db.Dispose();
        }
    }
}
