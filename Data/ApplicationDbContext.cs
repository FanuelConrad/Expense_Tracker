using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Expense_Tracker.Models;

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Expense_Tracker.Models.Category> Category { get; set; } = default!;

        public DbSet<Expense_Tracker.Models.Transaction>? Transactions { get; set; }
    }
