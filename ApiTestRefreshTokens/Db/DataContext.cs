using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiTestRefreshTokens.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApiTestRefreshTokens.Db
{
    public class DataContext : DbContext
    {
        //using database no sql
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<AppUser> AppUsers { get; set; }


    }
}
