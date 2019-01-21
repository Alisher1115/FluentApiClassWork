namespace FluentApi
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class SportContext : DbContext
    {
       
        public SportContext()
            : base("name=SportContext")
        {
        }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Player> Players{ get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Player>().HasRequired(player => player.Team).WithMany().HasForeignKey(player => player.TeamId);
        //    base.OnModelCreating(modelBuilder);
        //}
    }

}