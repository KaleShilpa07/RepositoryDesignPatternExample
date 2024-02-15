

using DebitCreditAmtExample.Model;
using Microsoft.EntityFrameworkCore;

namespace DebitCreditAmtExample.DataContext
{
    public class ComponyContext : DbContext
    {
            public ComponyContext(DbContextOptions<ComponyContext> options) : base(options)
            {

            }
            public DbSet<Transaction> transactions { get; set; }
           
        }
    }
