using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ReactAccountingWebMvc.Domain.Models;


namespace ReactAccountingWebMvc.Domain
{
    public partial class ApplicationContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<TwoModels> TwoModels { get; set; }
    }
}