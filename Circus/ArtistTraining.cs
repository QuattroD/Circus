//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Circus
{
    using System;
    using System.Collections.Generic;
    
    public partial class ArtistTraining
    {
        public int ArtistTraining1 { get; set; }
        public int User_ID { get; set; }
        public System.DateTime Start_Time { get; set; }
        public int Number_Hours { get; set; }
    
        public virtual User User { get; set; }
    }
}
