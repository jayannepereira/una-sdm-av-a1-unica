using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ValeAtivos32510087.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace ValeAtivos32510087.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){}
        public DbSet<Equipamento> Equipamentos { get; set; }
    }
}