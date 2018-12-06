namespace Wpfexam.Module
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }
        public virtual DbSet<AssignBooks> AssignBooks { get; set; }
        public virtual DbSet<books> books { get; set; }
        public virtual DbSet<Students> Students { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AssignBooks>()
    .Property(e => e.Penality)
    .HasPrecision(18, 0);

            modelBuilder.Entity<AssignBooks>()
                .Property(e => e.BookStatus)
                .IsUnicode(false);

            modelBuilder.Entity<books>()
                .Property(e => e.BookName)
                .IsUnicode(false);

            modelBuilder.Entity<books>()
                .Property(e => e.BookPublisherName)
                .IsUnicode(false);

            modelBuilder.Entity<books>()
                .Property(e => e.BookPrice)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Students>()
                .Property(e => e.NameStudent)
                .IsUnicode(false);

            modelBuilder.Entity<Students>()
                .Property(e => e.Branch)
                .IsUnicode(false);

            modelBuilder.Entity<Students>()
                .Property(e => e.YearStudy)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.UserPassword)
                .IsUnicode(false);
        }
    }
}
