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
    
    public partial class ProtocolAndUser
    {
        public string IsSigned => Signed ? "Подписано" : "Не подписано";
        public int ID { get; set; }
        public int ProtocolID { get; set; }
        public int UserID { get; set; }
        public string Comment { get; set; }
        public bool Signed { get; set; }
    
        public virtual Protocols Protocols { get; set; }
        public virtual User User { get; set; }
    }
}
