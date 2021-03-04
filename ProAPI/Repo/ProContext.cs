using Microsoft.EntityFrameworkCore;
using ProAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProAPI.Repo
{
    public class ProContext : DbContext
    {
        public ProContext(DbContextOptions<ProContext> opt): base(opt)
        {

        }
        public DbSet<Command> Commands { get; set; }
    }
}
