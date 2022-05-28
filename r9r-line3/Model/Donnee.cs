using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

using System.Linq;


namespace r9r_line3.Model
{
    public partial class Donnee : DbContext
    {
        public Donnee()
            : base("name=Donnee")
        {
        }

        public virtual DbSet<client> clients { get; set; }
        public virtual DbSet<commande> commandes { get; set; }
        public virtual DbSet<detailler> detaillers { get; set; }
        public virtual DbSet<voyage> voyages { get; set; }
        public virtual DbSet<contact> contacts { get; set; }
        public virtual DbSet<user> users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<client>()
                .Property(e => e.NOMCLIENT)
                .IsUnicode(false);

            modelBuilder.Entity<client>()
                .Property(e => e.PRENOMCLIENT)
                .IsUnicode(false);

            modelBuilder.Entity<client>()
                .Property(e => e.AGECLIENT)
                .IsUnicode(false);

            modelBuilder.Entity<client>()
                .Property(e => e.ADRESSECLIENT)
                .IsUnicode(false);

            modelBuilder.Entity<client>()
                .Property(e => e.MAILCLIENT)
                .IsUnicode(false);

            modelBuilder.Entity<voyage>()
                .Property(e => e.NOMVOYAGE)
                .IsUnicode(false);

            modelBuilder.Entity<voyage>()
                .Property(e => e.TYPEVOYAGE)
                .IsUnicode(false);

            modelBuilder.Entity<voyage>()
                .Property(e => e.STOCKVOYAGE)
                .IsUnicode(false);

            modelBuilder.Entity<voyage>()
                .Property(e => e.PAYSVOYAGE)
                .IsUnicode(false);

            modelBuilder.Entity<contact>()
                .Property(e => e.Prenom_Contact)
                .IsUnicode(false);

            modelBuilder.Entity<contact>()
                .Property(e => e.Nom_Contact)
                .IsUnicode(false);

            modelBuilder.Entity<contact>()
                .Property(e => e.Email_Contact)
                .IsUnicode(false);

            modelBuilder.Entity<contact>()
                .Property(e => e.Message_Contact)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.mdp)
                .IsUnicode(false);
        }
    }
}
