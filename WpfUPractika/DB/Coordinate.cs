//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfUPractika.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Coordinate
    {
        public int ID { get; set; }
        public double Latitude { get; set; }
        public double Longtitude { get; set; }
        public Nullable<int> DistrictId { get; set; }
    
        public virtual District District { get; set; }
    }
}