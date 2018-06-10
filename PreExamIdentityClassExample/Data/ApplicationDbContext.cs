using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PreExamIdentityClassExample.Entities;
using PreExamIdentityClassExample.Models;

namespace PreExamIdentityClassExample.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Note>(entity =>
            {
                entity.Property(e => e.NoteId).HasColumnName("NoteID");

                entity.Property(e => e.Title).HasMaxLength(50);
            });
        }

        public DbSet<PreExamIdentityClassExample.Entities.Note> Note { get; set; }
    }
}
