using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class NotTwitterDbContext : DbContext
    {
        public NotTwitterDbContext()
        { }

        public NotTwitterDbContext(DbContextOptions<NotTwitterDbContext> options) : base(options)
        { }

        // One DBSet per table
        public DbSet<Users> User { get; set; }
        public DbSet<Comments> Comments { get; set; }
        public DbSet<Friendships> Friendship{ get; set; }
        public DbSet<Posts> Posts { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(u => u.UserId);

                entity.Property(u => u.UserId)
                    .UseIdentityColumn(); // IDENTITY(1,1)

                entity.Property(u => u.FirstName)
                    .IsRequired() 
                    .HasMaxLength(50); 

                entity.Property(u => u.LastName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(u => u.Email)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(u => u.Gender)
                    .IsRequired();

                entity.Property(u => u.Username)
                   .HasMaxLength(50)
                   .IsRequired();

                entity.Property(u => u.Password)
                   .IsRequired();
            });

            modelBuilder.Entity<Comments>(entity =>
            {
                entity.HasKey(c => c.CommentId);


                entity.Property(c => c.CommentId)
                    .UseIdentityColumn();

                entity.Property(c => c.PostId)
                    .IsRequired()
                    .HasMaxLength(281);

                entity.Property(c => c.UserId);
                entity.Property(c => c.Content);
                entity.Property(c => c.CommentedDate);

                //Establishing Multiplicities as shown in PokeApp codefirst example, missing .HasForeignKey() (Not sure if it is included inside NPGSQL)
                /*
                   Example from PokeApp project: 
                   entity.HasOne(c => pt.Pokemon) // configure one nav property
                   .WithMany(p => p.PokemonTypeJoins) // configure the opposite nav property
                   .HasForeignKey(pt => pt.PokemonId) // configure the foreign key property
                   .IsRequired() // NOT NULL
                   .OnDelete(DeleteBehavior.Cascade); // ON DELETE CASCADE
                 */
                entity.HasOne(c => c.User).WithMany(u => u.Comments);
                entity.HasOne(c => c.Post).WithMany(p => p.Comments);
            });

            modelBuilder.Entity<Posts>(entity =>
            {
                entity.HasKey(p => p.PostId);

                entity.Property(p => p.PostId)
                    .UseIdentityColumn();

                entity.Property(p => p.UserId)
                    .IsRequired();

                entity.Property(p => p.Content)
                    .IsRequired();

                entity.Property(p => p.PostedDate)
                    .IsRequired();
            });

            modelBuilder.Entity<Friendships>(entity =>
            {
                //Composite key formed with User1ID and User2ID
                entity.HasKey(f => new { f.User1ID, f.User2ID});
                entity.Property(f => f.User1ID)
                    .IsRequired();

                entity.Property(f => f.User2ID)
                    .IsRequired(); 

                entity.Property(f => f.DateRequestSent)
                    .IsRequired();

                entity.Property(f => f.DateRequestConfirmed)
                    .IsRequired();
            });
        }
    }
}
}
