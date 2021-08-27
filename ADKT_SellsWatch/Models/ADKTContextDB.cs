using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ADKT_SellsWatch.Models
{
    public partial class ADKTContextDB : DbContext
    {
        public ADKTContextDB()
            : base("name=ADKTContextDB")
        {
        }

        public virtual DbSet<Brand> Brands { get; set; }
        public virtual DbSet<Membership> Memberships { get; set; }
        public virtual DbSet<Rank> Ranks { get; set; }
        public virtual DbSet<Receipt> Receipts { get; set; }
        public virtual DbSet<Receipt_Details> Receipt_Details { get; set; }
        public virtual DbSet<Staff> Staffs { get; set; }
        public virtual DbSet<Watch> Watches { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Brand>()
                .HasMany(e => e.Watches)
                .WithRequired(e => e.Brand)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Membership>()
                .Property(e => e.CustomerID)
                .IsUnicode(false);

            modelBuilder.Entity<Receipt>()
                .Property(e => e.CustomerID)
                .IsUnicode(false);

            modelBuilder.Entity<Receipt>()
                .Property(e => e.StaffID)
                .IsUnicode(false);

            modelBuilder.Entity<Receipt>()
                .Property(e => e.TotalPrice)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Receipt>()
                .HasMany(e => e.Receipt_Details)
                .WithRequired(e => e.Receipt)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Receipt_Details>()
                .Property(e => e.WatchID)
                .IsUnicode(false);

            modelBuilder.Entity<Staff>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<Staff>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Staff>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Staff>()
                .Property(e => e.Salary)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Staff>()
                .HasMany(e => e.Receipts)
                .WithOptional(e => e.Staff)
                .HasForeignKey(e => e.StaffID);

            modelBuilder.Entity<Watch>()
                .Property(e => e.WatchID)
                .IsUnicode(false);

            modelBuilder.Entity<Watch>()
                .Property(e => e.Waterproof)
                .IsUnicode(false);

            modelBuilder.Entity<Watch>()
                .Property(e => e.Price)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Watch>()
                .HasMany(e => e.Receipt_Details)
                .WithRequired(e => e.Watch)
                .WillCascadeOnDelete(false);
        }
    }
}
