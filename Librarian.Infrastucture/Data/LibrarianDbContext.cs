using Librarian.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Librarian.Infrastucture.Data
{
    public class LibrarianDbContext : DbContext
    {
        protected readonly IConfiguration _configuration;
        public LibrarianDbContext(DbContextOptions<LibrarianDbContext> options, IConfiguration configuration)
            : base(options)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseNpgsql(_configuration.GetConnectionString("LibrarianDatabase"))
                .UseSnakeCaseNamingConvention();
        }

        public DbSet<User> Users { get; set; }
    }
}
