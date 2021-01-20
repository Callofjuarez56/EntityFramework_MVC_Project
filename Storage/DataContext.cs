using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication6.Storage.Entity;

namespace WebApplication6.Storage
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) //передача опций, принимающие контекстом
        {

        }

        public DbSet<cal_c> Cal_Cs { get; set; }

        public DbSet<Subject> subj { get; set; }

        public DbSet<FirstM> mod_first { get; set; }

        public DbSet<SecondM> mod_sec { get; set; }

        public DbSet<Group> Groups { get; set; }
    }
}
