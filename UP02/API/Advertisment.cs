//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UP02.API
{
    using System;
    using System.Collections.Generic;
    
    public partial class Advertisment
    {
        public int Id { get; set; }
        public int AdOwner { get; set; }
        public int AdStatus { get; set; }
        public System.DateTime AdDate { get; set; }
        public int City { get; set; }
        public int Category { get; set; }
        public int AdType { get; set; }
        public string AdName { get; set; }
        public string AdDescription { get; set; }
        public Nullable<decimal> Price { get; set; }
        public string Photo { get; set; }
    
        public virtual AdType AdType1 { get; set; }
        public virtual User User { get; set; }
        public virtual Status Status { get; set; }
        public virtual Category Category1 { get; set; }
        public virtual City City1 { get; set; }
    }
}
