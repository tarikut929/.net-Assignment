using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using WebApplication5.Models;

namespace WebApplication5.Context
{
    public class InfoContext:DbContext
    {
        public DbSet<Info> Infos { get; set; }
        public DbSet<Post> Posts { get; set; }
    }
}
