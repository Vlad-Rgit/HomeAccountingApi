using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace HomeAccountingApi.Models
{
    public partial class Context : DbContext
    {
        public Context()
        {
        }

        public Context(DbContextOptions<Context> options)
            : base(options)
        {
            
        }

        public virtual DbSet<AccesToVentilation> AccesToVentilation { get; set; }
        public virtual DbSet<Bath> Bath { get; set; }
        public virtual DbSet<Bathroom> Bathroom { get; set; }
        public virtual DbSet<BathroomType> BathroomType { get; set; }
        public virtual DbSet<DraftVentilation> DraftVentilation { get; set; }
        public virtual DbSet<Flat> Flat { get; set; }
        public virtual DbSet<Home> Home { get; set; }
        public virtual DbSet<Kitchen> Kitchen { get; set; }
        public virtual DbSet<ReasonAbcenseInToilet> ReasonAbcenseInToilet { get; set; }
        public virtual DbSet<ReasonAbcenseToilet> ReasonAbcenseToilet { get; set; }
        public virtual DbSet<ReasonAbcenseVentilation> ReasonAbcenseVentilation { get; set; }
        public virtual DbSet<ReasonsAbcesnseInKitchen> ReasonsAbcesnseInKitchen { get; set; }
        public virtual DbSet<Redevelopment> Redevelopment { get; set; }
        public virtual DbSet<Toilet> Toilet { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Ventilation> Ventilation { get; set; }
        public virtual DbSet<WindowType> WindowType { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySQL("server=localhost;port=3306;user=root;password=Cortik228;database=home_accounting");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccesToVentilation>(entity =>
            {
                entity.ToTable("acces_to_ventilation");

                entity.Property(e => e.AccesToVentilationId)
                    .HasColumnName("acces_to_ventilation_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.AccesToVentilation1)
                    .IsRequired()
                    .HasColumnName("acces_to_ventilation")
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Bath>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("bath");

                entity.HasIndex(e => e.AccessToVentilationId)
                    .HasName("fk_acces_to_ventilation_idx");

                entity.HasIndex(e => e.BathroomId)
                    .HasName("fk_bath_bathroom_idx");

                entity.HasIndex(e => e.DraftVentilationId)
                    .HasName("fk_bath_darft_ventilation_idx");

                entity.Property(e => e.AccessToVentilationId)
                    .HasColumnName("access_to_ventilation_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.AnemonetrValue).HasColumnName("anemonetr_value");

                entity.Property(e => e.BathroomId)
                    .HasColumnName("bathroom_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.DraftVentilationId)
                    .HasColumnName("draft_ventilation_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.HasChannel).HasColumnName("has_channel");

                entity.Property(e => e.HeightChannel)
                    .HasColumnName("height_channel")
                    .HasColumnType("decimal(9,2)");

                entity.Property(e => e.Photo)
                    .HasColumnName("photo")
                    .HasColumnType("longblob");

                entity.Property(e => e.WidthChannel)
                    .HasColumnName("width_channel")
                    .HasColumnType("decimal(9,2)");

                entity.HasOne(d => d.AccessToVentilation)
                    .WithMany()
                    .HasForeignKey(d => d.AccessToVentilationId)
                    .HasConstraintName("fk_bath_acces_to_ventilation");

                entity.HasOne(d => d.Bathroom)
                    .WithMany()
                    .HasForeignKey(d => d.BathroomId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_bath_bathroom");

                entity.HasOne(d => d.DraftVentilation)
                    .WithMany()
                    .HasForeignKey(d => d.DraftVentilationId)
                    .HasConstraintName("fk_bath_darft_ventilation");
            });

            modelBuilder.Entity<Bathroom>(entity =>
            {
                entity.HasKey(e => e.FlatId)
                    .HasName("PRIMARY");

                entity.ToTable("bathroom");

                entity.HasIndex(e => e.BathroomTypeId)
                    .HasName("fk_bathroom_bathroom_type_idx");

                entity.Property(e => e.FlatId)
                    .HasColumnName("flat_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.BathroomTypeId)
                    .HasColumnName("bathroom_type_id")
                    .HasColumnType("int unsigned");

                entity.HasOne(d => d.BathroomType)
                    .WithMany(p => p.Bathroom)
                    .HasForeignKey(d => d.BathroomTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_bathroom_bathroom_type");

                entity.HasOne(d => d.Flat)
                    .WithOne(p => p.Bathroom)
                    .HasForeignKey<Bathroom>(d => d.FlatId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_batroom_flat");
            });

            modelBuilder.Entity<BathroomType>(entity =>
            {
                entity.ToTable("bathroom_type");

                entity.Property(e => e.BathroomTypeId)
                    .HasColumnName("bathroom_type_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.BathroomType1)
                    .IsRequired()
                    .HasColumnName("bathroom_type")
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DraftVentilation>(entity =>
            {
                entity.ToTable("draft_ventilation");

                entity.Property(e => e.DraftVentilationId)
                    .HasColumnName("draft_ventilation_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.DraftVentilation1)
                    .IsRequired()
                    .HasColumnName("draft_ventilation")
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Flat>(entity =>
            {
                entity.ToTable("flat");

                entity.HasIndex(e => e.HomeId)
                    .HasName("fk_flat_home_idx");

                entity.HasIndex(e => e.UserId)
                    .HasName("fk_flat_user_idx");

                entity.Property(e => e.FlatId)
                    .HasColumnName("flat_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.DateCreated).HasColumnName("date_created");

                entity.Property(e => e.Entrance).HasColumnName("entrance");

                entity.Property(e => e.Floor).HasColumnName("floor");

                entity.Property(e => e.HasAccess).HasColumnName("has_access");

                entity.Property(e => e.HomeId)
                    .HasColumnName("home_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.Number).HasColumnName("number");

                entity.Property(e => e.Post).HasColumnName("post");

                entity.Property(e => e.Signature)
                    .HasColumnName("signature")
                    .HasColumnType("longblob");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasColumnType("int unsigned");

                entity.HasOne(d => d.Home)
                    .WithMany(p => p.Flat)
                    .HasForeignKey(d => d.HomeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_flat_home");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Flat)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_flat_user");
            });

            modelBuilder.Entity<Home>(entity =>
            {
                entity.ToTable("home");

                entity.Property(e => e.HomeId)
                    .HasColumnName("home_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Photo)
                    .HasColumnName("photo")
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Kitchen>(entity =>
            {
                entity.HasKey(e => e.FlatId)
                    .HasName("PRIMARY");

                entity.ToTable("kitchen");

                entity.HasIndex(e => e.AccesToVentilationId)
                    .HasName("fk_kitchen_acces_to_ventilation_idx");

                entity.HasIndex(e => e.RedevelopmentId)
                    .HasName("fk_kitchen_redevelopment_idx");

                entity.HasIndex(e => e.WindowTypeId)
                    .HasName("fk_kitchen_window_type_idx");

                entity.Property(e => e.FlatId)
                    .HasColumnName("flat_id")
                    .HasColumnType("int unsigned")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AccesToVentilationId)
                    .HasColumnName("acces_to_ventilation_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.HasChannel).HasColumnName("has_channel");

                entity.Property(e => e.HasSupplyDevice).HasColumnName("has_supply_device");

                entity.Property(e => e.Photo)
                    .HasColumnName("photo")
                    .HasColumnType("longblob");

                entity.Property(e => e.RedevelopmentId)
                    .HasColumnName("redevelopment_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.WindowTypeId)
                    .HasColumnName("window_type_id")
                    .HasColumnType("int unsigned");

                entity.HasOne(d => d.AccesToVentilation)
                    .WithMany(p => p.Kitchen)
                    .HasForeignKey(d => d.AccesToVentilationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_kitchen_acces_to_ventilation");

                entity.HasOne(d => d.Flat)
                    .WithOne(p => p.Kitchen)
                    .HasForeignKey<Kitchen>(d => d.FlatId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_kitchen_flat");

                entity.HasOne(d => d.Redevelopment)
                    .WithMany(p => p.Kitchen)
                    .HasForeignKey(d => d.RedevelopmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_kitchen_redevelopment");

                entity.HasOne(d => d.WindowType)
                    .WithMany(p => p.Kitchen)
                    .HasForeignKey(d => d.WindowTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_kitchen_window_type");
            });

            modelBuilder.Entity<ReasonAbcenseInToilet>(entity =>
            {
                entity.HasKey(e => new { e.ToileteId, e.ReasonAbcenseToilet })
                    .HasName("PRIMARY");

                entity.ToTable("reason_abcense_in_toilet");

                entity.HasIndex(e => e.ReasonAbcenseToilet)
                    .HasName("fk_reasons_in_toilet_reason_idx");

                entity.Property(e => e.ToileteId)
                    .HasColumnName("toilete_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.ReasonAbcenseToilet)
                    .HasColumnName("reason_abcense_toilet")
                    .HasColumnType("int unsigned");

                entity.HasOne(d => d.ReasonAbcenseToiletNavigation)
                    .WithMany(p => p.ReasonAbcenseInToilet)
                    .HasForeignKey(d => d.ReasonAbcenseToilet)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_reasons_in_toilet_reason");

                entity.HasOne(d => d.Toilete)
                    .WithMany(p => p.ReasonAbcenseInToilet)
                    .HasForeignKey(d => d.ToileteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_reasons_in_toilet_toilet");
            });

            modelBuilder.Entity<ReasonAbcenseToilet>(entity =>
            {
                entity.ToTable("reason_abcense_toilet");

                entity.Property(e => e.ReasonAbcenseToiletId)
                    .HasColumnName("reason_abcense_toilet_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.ReasonAbcenseToilet1)
                    .IsRequired()
                    .HasColumnName("reason_abcense_toilet")
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ReasonAbcenseVentilation>(entity =>
            {
                entity.ToTable("reason_abcense_ventilation");

                entity.Property(e => e.ReasonAbcenseVentilationId)
                    .HasColumnName("reason_abcense_ventilation_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.ReasonAbcenseVentilation1)
                    .IsRequired()
                    .HasColumnName("reason_abcense_ventilation")
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ReasonsAbcesnseInKitchen>(entity =>
            {
                entity.HasKey(e => new { e.KithcenId, e.ReasonAbcenseVentilationId })
                    .HasName("PRIMARY");

                entity.ToTable("reasons_abcesnse_in_kitchen");

                entity.HasIndex(e => e.ReasonAbcenseVentilationId)
                    .HasName("fk_reasons_abcesnse_in_kitchen_idx");

                entity.Property(e => e.KithcenId)
                    .HasColumnName("kithcen_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.ReasonAbcenseVentilationId)
                    .HasColumnName("reason_abcense_ventilation_id")
                    .HasColumnType("int unsigned");

                entity.HasOne(d => d.Kithcen)
                    .WithMany(p => p.ReasonsAbcesnseInKitchen)
                    .HasForeignKey(d => d.KithcenId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_reasons_abcesnse_in_kitchen_kitchen");

                entity.HasOne(d => d.ReasonAbcenseVentilation)
                    .WithMany(p => p.ReasonsAbcesnseInKitchen)
                    .HasForeignKey(d => d.ReasonAbcenseVentilationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_reasons_abcesnse_in_kitchen");
            });

            modelBuilder.Entity<Redevelopment>(entity =>
            {
                entity.ToTable("redevelopment");

                entity.Property(e => e.RedevelopmentId)
                    .HasColumnName("redevelopment_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.Redevelopment1)
                    .IsRequired()
                    .HasColumnName("redevelopment")
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Toilet>(entity =>
            {
                entity.HasKey(e => e.BathroomId)
                    .HasName("PRIMARY");

                entity.ToTable("toilet");

                entity.HasIndex(e => e.AccesToVentilationId)
                    .HasName("fk_toilet_access_to_ventilation_idx");

                entity.HasIndex(e => e.DraftVentilationId)
                    .HasName("fk_toilet_draft_ventilation_idx");

                entity.Property(e => e.BathroomId)
                    .HasColumnName("bathroom_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.AccesToVentilationId)
                    .HasColumnName("acces_to_ventilation_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.DraftVentilationId)
                    .HasColumnName("draft_ventilation_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.HasChannel).HasColumnName("has_channel");

                entity.Property(e => e.HeightChannel)
                    .HasColumnName("height_channel")
                    .HasColumnType("decimal(9,2)");

                entity.Property(e => e.Photo)
                    .HasColumnName("photo")
                    .HasColumnType("longblob");

                entity.Property(e => e.WidthChannle)
                    .HasColumnName("width_channle")
                    .HasColumnType("decimal(9,2)");

                entity.HasOne(d => d.AccesToVentilation)
                    .WithMany(p => p.Toilet)
                    .HasForeignKey(d => d.AccesToVentilationId)
                    .HasConstraintName("fk_toilet_access_to_ventilation");

                entity.HasOne(d => d.DraftVentilation)
                    .WithMany(p => p.Toilet)
                    .HasForeignKey(d => d.DraftVentilationId)
                    .HasConstraintName("fk_toilet_draft_ventilation");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("user");

                entity.Property(e => e.UserId)
                    .HasColumnName("userId")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.Fio)
                    .IsRequired()
                    .HasColumnName("fio")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Login)
                    .IsRequired()
                    .HasColumnName("login")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Photo)
                    .HasColumnName("photo")
                    .HasColumnType("longblob");
            });

            modelBuilder.Entity<Ventilation>(entity =>
            {
                entity.HasKey(e => e.KitchernId)
                    .HasName("PRIMARY");

                entity.ToTable("ventilation");

                entity.HasIndex(e => e.DraftVentilationId)
                    .HasName("fk_ventilation_draft_idx");

                entity.Property(e => e.KitchernId)
                    .HasColumnName("kitchern_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.AnemometrValue).HasColumnName("anemometr_value");

                entity.Property(e => e.DraftVentilationId)
                    .HasColumnName("draft_ventilation_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.HasDefects).HasColumnName("has_defects");

                entity.Property(e => e.HeightChannel)
                    .HasColumnName("height_channel")
                    .HasColumnType("decimal(9,2)");

                entity.Property(e => e.WidthChannel)
                    .HasColumnName("width_channel")
                    .HasColumnType("decimal(9,2)");

                entity.HasOne(d => d.DraftVentilation)
                    .WithMany(p => p.Ventilation)
                    .HasForeignKey(d => d.DraftVentilationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ventilation_draft");

                entity.HasOne(d => d.Kitchern)
                    .WithOne(p => p.Ventilation)
                    .HasForeignKey<Ventilation>(d => d.KitchernId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ventilation_kitchen");
            });

            modelBuilder.Entity<WindowType>(entity =>
            {
                entity.ToTable("window_type");

                entity.Property(e => e.WindowTypeId)
                    .HasColumnName("window_type_id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.WindowType1)
                    .IsRequired()
                    .HasColumnName("window_type")
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
