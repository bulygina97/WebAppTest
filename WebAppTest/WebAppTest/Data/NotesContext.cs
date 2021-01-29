using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppTest.Controllers;
using WebAppTest.Models;

namespace WebAppTest.Data
{
    public class NotesContext: DbContext
    {
        public NotesContext(DbContextOptions<NotesContext> options) : base(options)
        {
        }

        public DbSet<Note> Note { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Tag> Tag { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Note>().ToTable("Note");
            modelBuilder.Entity<Category>().ToTable("Category");
            modelBuilder.Entity<Tag>().ToTable("Tag");
        }
    }
}
