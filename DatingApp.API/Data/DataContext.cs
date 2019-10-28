using DatingApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Data
{
    public class DataContext : DbContext //take from upper class
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options) //ctor generates constructor structure
        {}
        public DbSet<Value> Values { get; set; }
    }
}