namespace PublierDocuments2017
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModelGestionpublierDocumnets : DbContext
    {
        public ModelGestionpublierDocumnets()
            : base("name=ModelGestionpublierDocumnets1")
        {
        }

        public virtual DbSet<Commentaire> Commentaire { get; set; }
        public virtual DbSet<Document> Document { get; set; }
        public virtual DbSet<Mombre> Mombre { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Commentaire>()
                .Property(e => e.text_commentaire)
                .IsUnicode(false);

            modelBuilder.Entity<Commentaire>()
                .Property(e => e.etat_commentaire)
                .IsUnicode(false);

            modelBuilder.Entity<Commentaire>()
                .Property(e => e.login_)
                .IsUnicode(false);

            modelBuilder.Entity<Document>()
                .Property(e => e.description_document)
                .IsUnicode(false);

            modelBuilder.Entity<Document>()
                .Property(e => e.theme)
                .IsUnicode(false);

            modelBuilder.Entity<Mombre>()
                .Property(e => e.login_)
                .IsUnicode(false);

            modelBuilder.Entity<Mombre>()
                .Property(e => e.passe)
                .IsUnicode(false);
        }
    }
}
