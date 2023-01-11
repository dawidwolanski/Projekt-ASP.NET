using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace bank2.Models
{
    public class BankingContext : DbContext
    {
        public DbSet<Operation> Operations { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<User> Users { get; set; }

        private string DbPath = "./database.db";
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");
    }

    public class User
    {
        public int ID { get; set; }
        public string Login { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Display(Name = "Hasło")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public int IsAdmin { get; set; }
        public float Saldo { get; set; }
        public int DefaultCurrencyID { get; set; }
    }

    public class Operation
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public float Amount { get; set; }
        public DateTime Date { get; set; }
        public int CurrencyID { get; set; }
        public string Type { get; set; }
    }

    public class Currency
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public float ExchangeRate { get; set; }
    }
}
