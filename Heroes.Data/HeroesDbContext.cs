using HeroApp.Data.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;

namespace HeroApp.Data.Model
{
    public partial class HeroesDbContext : DbContext
    {
        public virtual DbSet<Movie> Movies { get; set; }
        public virtual DbSet<Team> Teams { get; set; }
        public virtual DbSet<Hero> Heroes { get; set; }

        public HeroesDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Regular entities
            modelBuilder.Entity<Movie>()
                .ToTable("Movies")
                .HasKey(e => e.Id);

            modelBuilder.Entity<Team>()
                .ToTable("Teams")
                .HasKey(e => e.Id);

            modelBuilder.Entity<Hero>()
                .ToTable("Heroes")
                .HasKey(e => e.Id);

            modelBuilder.Entity<SecretIdentity>()
                .ToTable("SecretIdentities")
                .HasKey(e => e.Id);

            modelBuilder.Entity<Ability>()
                .ToTable("Abilities")
                .HasKey(e => e.Id);

            modelBuilder.Entity<Weapon>()
                .ToTable("Weapons")
                .HasKey(e => e.Id);

            //One to One
            modelBuilder.Entity<Hero>()
                .HasOne(e => e.SecretIdentity)
                .WithOne(e => e.Hero)
                .HasForeignKey<SecretIdentity>(e => e.HeroId)
                .IsRequired();

            //One to Many
            modelBuilder.Entity<Weapon>()
                .HasOne(e => e.Hero)
                .WithMany(e => e.Weapons)
                .HasForeignKey(e => e.HeroId);
            //Not Required

            modelBuilder.Entity<Team>()
                .HasOne(e => e.Movie)
                .WithMany(e => e.Teams)
                .HasForeignKey(e => e.MovieId)
                .IsRequired();

            modelBuilder.Entity<Team>()
               .HasOne(e => e.Leader)
               .WithMany()
               .HasForeignKey(e => e.LeaderId)
               .IsRequired();

            //Many to Many
            modelBuilder.Entity<HeroAbility>()
                .ToTable("HeroAbilities")
                .HasKey(e => new { e.HeroId, e.AbilityId });

            modelBuilder.Entity<HeroAbility>()
                .HasOne(e => e.Hero)
                .WithMany(e => e.LinkedAbilities)
                .HasForeignKey(e => e.HeroId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<HeroAbility>()
                .HasOne(e => e.Ability)
                .WithMany(e => e.LinkedHeroes)
                .HasForeignKey(e => e.AbilityId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<WeaponAbility>()
                .ToTable("WeaponAbilities")
                .HasKey(e => new { e.WeaponId, e.AbilityId });

            modelBuilder.Entity<WeaponAbility>()
                .HasOne(e => e.Weapon)
                .WithMany(e => e.LinkedAbilities)
                .HasForeignKey(e => e.WeaponId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<WeaponAbility>()
                .HasOne(e => e.Ability)
                .WithMany(e => e.LinkedWeapons)
                .HasForeignKey(e => e.AbilityId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<TeamMember>()
                .ToTable("TeamMembers")
                .HasKey(e => new { e.TeamId, e.MemberId });

            modelBuilder.Entity<TeamMember>()
                .HasOne(e => e.Team)
                .WithMany(e => e.TeamMembers)
                .HasForeignKey(e => e.TeamId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<TeamMember>()
                .HasOne(e => e.Member)
                .WithMany(e => e.LinkedTeams)
                .HasForeignKey(e => e.MemberId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            base.OnModelCreating(modelBuilder);

            SeedData(modelBuilder);
        }
    }
}