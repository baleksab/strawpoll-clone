using Entities;
using Microsoft.EntityFrameworkCore;

namespace Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options){}

    public DbSet<User> Users { get; set; }
    public DbSet<Poll> Polls { get; set; }
    public DbSet<Options> Options { get; set; }
    public DbSet<MultipleChoiceOption> MultipleChoiceOptions { get; set; }
    public DbSet<ImageOption> ImageOptions { get; set; }
    public DbSet<RankingOption> RankingOptions { get; set; }
    public DbSet<MeetingOption> MeetingOptions { get; set; }
    public DbSet<Vote> Votes { get; set; }
    public DbSet<ImageSettings> ImageSettings { get; set; }
    public DbSet<MultipleChoiceSettings> MultipleChoiceSettings { get; set; }
    public DbSet<RankingSettings> RankingSettings { get; set; }
    public DbSet<MeetingSettings> MeetingSettings { get; set; }
    public DbSet<AdvancedSettings> AdvancedSettings { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Poll>()
            .Property(p => p.PollType)
            .HasConversion<string>();

        modelBuilder.Entity<Options>()
            .Property(o => o.OptionType)
            .HasConversion<string>();

        modelBuilder.Entity<AdvancedSettings>()
            .Property(a => a.ResultVisibility)
            .HasConversion<string>();

        modelBuilder.Entity<AdvancedSettings>()
            .Property(a => a.VotingSecurity)
            .HasConversion<string>();

        modelBuilder.Entity<AdvancedSettings>()
            .Property(a => a.EditVotePermissions)
            .HasConversion<string>();

        modelBuilder.Entity<MultipleChoiceOption>().HasBaseType<Options>();
        modelBuilder.Entity<ImageOption>().HasBaseType<Options>();
        modelBuilder.Entity<RankingOption>().HasBaseType<Options>();
        modelBuilder.Entity<MeetingOption>().HasBaseType<Options>();

        modelBuilder.Entity<Vote>()
            .HasOne(v => v.Poll)
            .WithMany()
            .OnDelete(DeleteBehavior.Restrict);

        base.OnModelCreating(modelBuilder);
    }

}