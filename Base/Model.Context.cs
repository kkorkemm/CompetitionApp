namespace CompetitionApp.Base
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CompetitionDBEntities : DbContext
    {
        public CompetitionDBEntities()
            : base("name=CompetitionDBEntities2")
        {
        }

        private static CompetitionDBEntities context;
        public static CompetitionDBEntities GetContext()
        {
            if (context == null)
                context = new CompetitionDBEntities();
            return context;
        }

        public static User currentUser;
        public static Competition currentCompettion;
        public static Day currentDay;

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Competition> Competition { get; set; }
        public virtual DbSet<Day> Day { get; set; }
        public virtual DbSet<Expert> Expert { get; set; }
        public virtual DbSet<ExpertRole> ExpertRole { get; set; }
        public virtual DbSet<Gender> Gender { get; set; }
        public virtual DbSet<ProtocolAndUser> ProtocolAndUser { get; set; }
        public virtual DbSet<ProtocolExtraDateField> ProtocolExtraDateField { get; set; }
        public virtual DbSet<ProtocolExtraTextField> ProtocolExtraTextField { get; set; }
        public virtual DbSet<ProtocolExtraTimeStampField> ProtocolExtraTimeStampField { get; set; }
        public virtual DbSet<Protocols> Protocols { get; set; }
        public virtual DbSet<Region> Region { get; set; }
        public virtual DbSet<RegionDistrict> RegionDistrict { get; set; }
        public virtual DbSet<Skill> Skill { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserRole> UserRole { get; set; }
        public virtual DbSet<UserStatus> UserStatus { get; set; }
        public virtual DbSet<ProtocolFinished> ProtocolFinished { get; set; }
    }
}
