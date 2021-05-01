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
    
    public partial class ExpertRole
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ExpertRole()
        {
            this.Expert = new HashSet<Expert>();
        }
    
        public int ID { get; set; }
        public int CompetiotionID { get; set; }
        public string ExpertRoleName { get; set; }
        public string Description { get; set; }
        public Nullable<byte> MinExpertCount { get; set; }
        public Nullable<byte> MaxExpertCount { get; set; }
    
        public virtual Competition Competition { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Expert> Expert { get; set; }
    }
}
