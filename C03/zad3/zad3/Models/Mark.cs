//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace zad3.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Mark
    {
        public long Id { get; set; }
        public double Value { get; set; }
        public long IdStudent { get; set; }
        public long IdCourse { get; set; }
    
        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }
    }
}
