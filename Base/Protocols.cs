//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CompetitionApp.Base
{
    using System;
    using System.Collections.Generic;
    
    public partial class Protocols
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Protocols()
        {
            this.ProtocolAndUser = new HashSet<ProtocolAndUser>();
            this.ProtocolExtraDateField = new HashSet<ProtocolExtraDateField>();
            this.ProtocolExtraTextField = new HashSet<ProtocolExtraTextField>();
            this.ProtocolExtraTimeStampField = new HashSet<ProtocolExtraTimeStampField>();
        }

        public string IsActive => Active ? "Да" : "Нет";

        public int ID { get; set; }
        public string ProtocolName { get; set; }
        public string Content { get; set; }
        public short UserRoleID { get; set; }
        public int DayID { get; set; }
        public bool Active { get; set; }
        public bool Finished { get; set; }
    
        public virtual Day Day { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProtocolAndUser> ProtocolAndUser { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProtocolExtraDateField> ProtocolExtraDateField { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProtocolExtraTextField> ProtocolExtraTextField { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProtocolExtraTimeStampField> ProtocolExtraTimeStampField { get; set; }
        public virtual UserRole UserRole { get; set; }
    }
}
