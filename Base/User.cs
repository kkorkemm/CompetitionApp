namespace CompetitionApp.Base
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            this.Expert = new HashSet<Expert>();
            this.ProtocolAndUser = new HashSet<ProtocolAndUser>();
        }

        public string FullName => Surname + " " + Name[0] + ". " + LastName[0] + ".";
        public int FullAge => DateTime.Now.Year - BirthDate.Year;
        public string FullAgeString
        {
            get
            {
                if (FullAge % 10 == 1)
                {
                    return $"{FullAge} год";
                }
                else if (FullAge % 10 <= 4)
                {
                    return $"{FullAge} года";
                }
                else
                {
                    return $"{FullAge} лет";
                }
            }
        }
        public string Status => UserStatus.ID != 1 ? UserStatus.StatusName + "-ожидает подтверждения" : UserStatus.StatusName;

        public bool UserConfirm => UserStatusID != 1 ? true : false;

        public int ID { get; set; }
        public int CompetiotionID { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string PIN { get; set; }
        public byte GenderID { get; set; }
        public System.DateTime BirthDate { get; set; }
        public short UserRoleID { get; set; }
        public string SkillID { get; set; }
        public Nullable<int> RegionID { get; set; }
        public short UserStatusID { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    
        public virtual Competition Competition { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Expert> Expert { get; set; }
        public virtual Expert Expert1 { get; set; }
        public virtual Gender Gender { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProtocolAndUser> ProtocolAndUser { get; set; }
        public virtual Region Region { get; set; }
        public virtual Skill Skill { get; set; }
        public virtual UserRole UserRole { get; set; }
        public virtual UserStatus UserStatus { get; set; }
    }
}
