//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OOP_Community.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Address
    {
        public int id { get; set; }
        public Nullable<int> resident { get; set; }
        public string lot { get; set; }
        public string block { get; set; }
        public string street { get; set; }
        public string subdivision { get; set; }
    
        public virtual Resident Resident1 { get; set; }
    }
}
