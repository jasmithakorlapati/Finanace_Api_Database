using Microsoft.EntityFrameworkCore;

namespace Finanace_Api.Models
{
    public class FinanceDbContext:DbContext
    {
        public FinanceDbContext()
        {

        }
        public FinanceDbContext(DbContextOptions<FinanceDbContext> options) : base(options) { }
     
        public virtual DbSet<Role> Roles { get; set; }  
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Budget> Budgets { get; set; }
        public virtual DbSet<Expense> Expenses { get; set; }
        public virtual DbSet<Income> Incomes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
       => optionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS;Initial Catalog=FinanceManagementSystem;Integrated Security=True;TrustServerCertificate=True");



    }
}
