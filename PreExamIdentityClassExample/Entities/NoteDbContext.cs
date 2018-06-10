using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PreExamIdentityClassExample.Entities
{
    public partial class NoteDbContext : DbContext
    {
        public virtual DbSet<Note> Note { get; set; }

        public NoteDbContext(DbContextOptions<NoteDbContext> options) : base (options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Note>(entity =>
            {
                entity.Property(e => e.NoteId).HasColumnName("NoteID");

                entity.Property(e => e.Title).HasMaxLength(50);
            });
        }
    }
}
