namespace CompetitionApp.Base
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CompetitionDBEntities : DbContext
    {
        public CompetitionDBEntities()
            : base("name=CompetitionDBEntities")
        {
        }

        private static CompetitionDBEntities _context;
        public static CompetitionDBEntities GetContext()
        {
            if (_context == null)
                _context = new CompetitionDBEntities();

            return _context;
        }

        public static User currentUser;
        public static Competition currentCompettion;

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
        public virtual DbSet<Protocols> Protocols { get; set; }
        public virtual DbSet<Region> Region { get; set; }
        public virtual DbSet<RegionDistrict> RegionDistrict { get; set; }
        public virtual DbSet<Skill> Skill { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserRole> UserRole { get; set; }
        public virtual DbSet<UserStatus> UserStatus { get; set; }
    }
}
