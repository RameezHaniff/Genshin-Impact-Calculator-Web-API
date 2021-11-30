using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace GenshinWebApp.Models
{
    public partial class GenshinImpactContext : DbContext
    {
        public GenshinImpactContext()
        {
        }

        public GenshinImpactContext(DbContextOptions<GenshinImpactContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Ability> Abilities { get; set; }
        public virtual DbSet<AbilityDamage> AbilityDamages { get; set; }
        public virtual DbSet<AbilityDamageInstance> AbilityDamageInstances { get; set; }
        public virtual DbSet<AbilityScaling> AbilityScalings { get; set; }
        public virtual DbSet<Amber> Ambers { get; set; }
        public virtual DbSet<Character> Characters { get; set; }
        public virtual DbSet<CharacterAbility> CharacterAbilities { get; set; }
        public virtual DbSet<Element> Elements { get; set; }
        public virtual DbSet<Rarity> Rarities { get; set; }
        public virtual DbSet<WeaponType> WeaponTypes { get; set; }

        public virtual DbSet<AbilityScalingValue> AbilityScalingValues { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseNpgsql("Host=localhost;Database=Genshin_Impact;Username=postgres;Password=doublade");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "English_South Africa.1252");

            modelBuilder.Entity<Ability>(entity =>
            {
                entity.ToTable("ability");

                entity.Property(e => e.AbilityId)
                    .ValueGeneratedNever()
                    .HasColumnName("ability_id");

                entity.Property(e => e.AbilityName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("ability_name");

                entity.Property(e => e.Cooldown).HasColumnName("cooldown");

                entity.Property(e => e.EnergyCost).HasColumnName("energy_cost");
            });

            modelBuilder.Entity<AbilityDamage>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ability_damage");

                entity.Property(e => e.AbilityDamageId).HasColumnName("ability_damage_id");

                entity.Property(e => e.AbilityDamageInstanceId).HasColumnName("ability_damage_instance_id");

                entity.Property(e => e.AbilityId).HasColumnName("ability_id");

                entity.HasOne(d => d.AbilityDamageInstance)
                    .WithMany()
                    .HasForeignKey(d => d.AbilityDamageInstanceId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("fk_ability_damage_instance_id");

                entity.HasOne(d => d.Ability)
                    .WithMany()
                    .HasForeignKey(d => d.AbilityId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("fk_ability_id");
            });

            modelBuilder.Entity<AbilityDamageInstance>(entity =>
            {
                entity.ToTable("ability_damage_instance");

                entity.Property(e => e.AbilityDamageInstanceId)
                    .ValueGeneratedNever()
                    .HasColumnName("ability_damage_instance_id");

                entity.Property(e => e.DamageInstanceName)
                    .HasMaxLength(100)
                    .HasColumnName("damage_instance_name");

                entity.Property(e => e.ScalingId).HasColumnName("scaling_id");

                //entity.HasOne(d => d.Scaling)
                //    .WithMany(p => p.AbilityDamageInstances)
                //    .HasForeignKey(d => d.ScalingId)
                //    .OnDelete(DeleteBehavior.SetNull)
                //    .HasConstraintName("fk_ability_scaling");
            });

            modelBuilder.Entity<AbilityScaling>(entity =>
            {
                entity.HasKey(e => e.ScalingId)
                    .HasName("ability_scaling_pkey");

                entity.ToTable("ability_scaling");

                entity.Property(e => e.ScalingId)
                    .ValueGeneratedNever()
                    .HasColumnName("scaling_id");

                entity.Property(e => e.Level1).HasColumnName("level_1");

                entity.Property(e => e.Level10).HasColumnName("level_10");

                entity.Property(e => e.Level11).HasColumnName("level_11");

                entity.Property(e => e.Level12).HasColumnName("level_12");

                entity.Property(e => e.Level13).HasColumnName("level_13");

                entity.Property(e => e.Level14).HasColumnName("level_14");

                entity.Property(e => e.Level15).HasColumnName("level_15");

                entity.Property(e => e.Level2).HasColumnName("level_2");

                entity.Property(e => e.Level3).HasColumnName("level_3");

                entity.Property(e => e.Level4).HasColumnName("level_4");

                entity.Property(e => e.Level5).HasColumnName("level_5");

                entity.Property(e => e.Level6).HasColumnName("level_6");

                entity.Property(e => e.Level7).HasColumnName("level_7");

                entity.Property(e => e.Level8).HasColumnName("level_8");

                entity.Property(e => e.Level9).HasColumnName("level_9");

                entity.Property(e => e.DamageType).HasColumnName("damage_type");
            });

            modelBuilder.Entity<Amber>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("amber");

                entity.Property(e => e.AbilityDamageInstanceId).HasColumnName("ability_damage_instance_id");

                entity.Property(e => e.AbilityId).HasColumnName("ability_id");

                entity.Property(e => e.CharacterId).HasColumnName("character_id");

                entity.Property(e => e.CharacterName)
                    .HasMaxLength(55)
                    .HasColumnName("character_name");

                entity.Property(e => e.Level1).HasColumnName("level_1");

                entity.Property(e => e.Level10).HasColumnName("level_10");

                entity.Property(e => e.Level11).HasColumnName("level_11");

                entity.Property(e => e.Level12).HasColumnName("level_12");

                entity.Property(e => e.Level13).HasColumnName("level_13");

                entity.Property(e => e.Level14).HasColumnName("level_14");

                entity.Property(e => e.Level15).HasColumnName("level_15");

                entity.Property(e => e.Level2).HasColumnName("level_2");

                entity.Property(e => e.Level3).HasColumnName("level_3");

                entity.Property(e => e.Level4).HasColumnName("level_4");

                entity.Property(e => e.Level5).HasColumnName("level_5");

                entity.Property(e => e.Level6).HasColumnName("level_6");

                entity.Property(e => e.Level7).HasColumnName("level_7");

                entity.Property(e => e.Level8).HasColumnName("level_8");

                entity.Property(e => e.Level9).HasColumnName("level_9");

                entity.Property(e => e.ScalingId).HasColumnName("scaling_id");
            });

            modelBuilder.Entity<Character>(entity =>
            {
                entity.ToTable("character");

                entity.Property(e => e.CharacterId)
                    .ValueGeneratedNever()
                    .HasColumnName("character_id");

                entity.Property(e => e.CharacterName)
                    .IsRequired()
                    .HasMaxLength(55)
                    .HasColumnName("character_name");

                entity.Property(e => e.ElementId).HasColumnName("element_id");

                entity.Property(e => e.RarityId).HasColumnName("rarity_id");

                entity.Property(e => e.WeaponTypeId).HasColumnName("weapon_type_id");

            });

            modelBuilder.Entity<CharacterAbility>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("character_ability");

                entity.Property(e => e.AbilityId).HasColumnName("ability_id");

                entity.Property(e => e.CharacterAbilityId).HasColumnName("character_ability_id");

                entity.Property(e => e.CharacterId).HasColumnName("character_id");

                entity.HasOne(d => d.Ability)
                    .WithMany()
                    .HasForeignKey(d => d.AbilityId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("fk_ability_id");

                entity.HasOne(d => d.Character)
                    .WithMany()
                    .HasForeignKey(d => d.CharacterId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("fk_character_id");
            });

            modelBuilder.Entity<Element>(entity =>
            {
                entity.ToTable("elements");

                entity.Property(e => e.ElementId)
                    .ValueGeneratedNever()
                    .HasColumnName("element_id");

                entity.Property(e => e.ElementName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("element_name");
            });

            modelBuilder.Entity<Rarity>(entity =>
            {
                entity.ToTable("rarity");

                entity.Property(e => e.RarityId)
                    .ValueGeneratedNever()
                    .HasColumnName("rarity_id");

                entity.Property(e => e.RarityName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("rarity_name");
            });

            modelBuilder.Entity<WeaponType>(entity =>
            {
                entity.ToTable("weapon_type");

                entity.Property(e => e.WeaponTypeId)
                    .ValueGeneratedNever()
                    .HasColumnName("weapon_type_id");

                entity.Property(e => e.WeaponTypeName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("weapon_type_name");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
