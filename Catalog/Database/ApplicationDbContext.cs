using Catalog.Models.Comments;
using Catalog.Models.Questionnaires;
using Catalog.Models.Questions;
using Catalog.Models.Requests;
using Catalog.Models.Requirements;
using Catalog.Models.Users;
using Microsoft.EntityFrameworkCore;

namespace Catalog.Database
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Questionnaire> Questionnaires { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Trigger> Triggers { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<ComplianceProcess> ComplianceProcesses { get; set; }
        public DbSet<ComplianceRisk> ComplianceRisks { get; set; }
        public DbSet<RelationStage> RelationStages { get; set; }
        public DbSet<Requirement> Requirements { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Trigger>(entity =>
            {
                entity.HasMany(x => x.AnyTriggerSets)
                    .WithMany(y => y.AnyTriggers)
                    .UsingEntity(s => s.ToTable("AnyTriggerRelations"));
                entity.HasMany(x => x.RequiredTriggerSets)
                    .WithMany(y => y.RequiredTriggers)
                    .UsingEntity(s => s.ToTable("RequiredTriggerRelations"));
            });
            modelBuilder.Entity<Request>(entity =>
            {
                entity.HasOne(x => x.BusinessClient)
                    .WithMany(y => y.Requests)
                    .HasForeignKey(x => x.BusinessClientId)
                    .OnDelete(DeleteBehavior.Cascade);
            });
        }
    }
}