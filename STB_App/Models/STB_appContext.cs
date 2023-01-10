using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace STB_App.Models2
{
    public partial class STB_appContext : DbContext
    {
        public STB_appContext()
        {
        }

        public STB_appContext(DbContextOptions<STB_appContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CardDetails> CardDetails { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Person> Person { get; set; }
        public virtual DbSet<RefRouteSubscription> RefRouteSubscription { get; set; }
        public virtual DbSet<RefStationRoute> RefStationRoute { get; set; }
        public virtual DbSet<Routes> Routes { get; set; }
        public virtual DbSet<Stations> Stations { get; set; }
        public virtual DbSet<SubscriptionHistory> SubscriptionHistory { get; set; }
        public virtual DbSet<TicketHistory> TicketHistory { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.;Database=STB_app;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CardDetails>(entity =>
            {
                entity.HasKey(e => e.CardId);

                entity.Property(e => e.Cvv)
                    .IsRequired()
                    .HasColumnName("CVV")
                    .HasMaxLength(3);

                entity.Property(e => e.DataExpirare)
                    .IsRequired()
                    .HasMaxLength(8);

                entity.Property(e => e.NumarCard)
                    .IsRequired()
                    .HasMaxLength(16);

                entity.HasOne(d => d.Persoana)
                    .WithMany(p => p.CardDetails)
                    .HasForeignKey(d => d.PersoanaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CardDetails");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.Property(e => e.PersonType)
                    .IsRequired()
                    .HasMaxLength(16);
            });

            modelBuilder.Entity<Person>(entity =>
            {
                entity.Property(e => e.Email).HasMaxLength(32);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(16);

                entity.Property(e => e.Passw)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.Property(e => e.PhoneNumber).HasMaxLength(16);

                entity.Property(e => e.PicturePath).HasMaxLength(128);

                entity.Property(e => e.SecondName)
                    .IsRequired()
                    .HasMaxLength(16);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Person)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_Person");
            });

            modelBuilder.Entity<RefRouteSubscription>(entity =>
            {
                entity.HasKey(e => e.RefId)
                    .HasName("PK_Ref");

                entity.HasOne(d => d.Route)
                    .WithMany(p => p.RefRouteSubscription)
                    .HasForeignKey(d => d.RouteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK1_ref");

                entity.HasOne(d => d.Subscription)
                    .WithMany(p => p.RefRouteSubscription)
                    .HasForeignKey(d => d.SubscriptionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK2_ref");
            });

            modelBuilder.Entity<RefStationRoute>(entity =>
            {
                entity.HasOne(d => d.Route)
                    .WithMany(p => p.RefStationRoute)
                    .HasForeignKey(d => d.RouteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Ref1");

                entity.HasOne(d => d.Station)
                    .WithMany(p => p.RefStationRoute)
                    .HasForeignKey(d => d.StationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Ref2");
            });

            modelBuilder.Entity<Routes>(entity =>
            {
                entity.HasKey(e => e.RouteId)
                    .HasName("PK_Route");
            });

            modelBuilder.Entity<Stations>(entity =>
            {
                entity.HasKey(e => e.StationId)
                    .HasName("PK_Station");

                entity.Property(e => e.StationName)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<SubscriptionHistory>(entity =>
            {
                entity.HasKey(e => e.SubscriptionId);

                entity.Property(e => e.DateFinish).HasColumnType("date");

                entity.Property(e => e.DateStart).HasColumnType("date");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.SubscriptionHistory)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SubscriptionHistory");
            });

            modelBuilder.Entity<TicketHistory>(entity =>
            {
                entity.HasKey(e => e.TicketId)
                    .HasName("PK_Ticket");

                entity.Property(e => e.DataBilet)
                    .HasColumnName("Data_bilet")
                    .HasColumnType("date");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.TicketHistory)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK1_Ticket");

                entity.HasOne(d => d.Route)
                    .WithMany(p => p.TicketHistory)
                    .HasForeignKey(d => d.RouteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK2_Ticket");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
