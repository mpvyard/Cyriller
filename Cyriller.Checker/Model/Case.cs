//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cyriller.Checker.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Case
    {
        public Case()
        {
            this.WordCases = new HashSet<WordCase>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string SysName { get; set; }
        public int OrderNumber { get; set; }
        public string Comments { get; set; }
    
        public virtual ICollection<WordCase> WordCases { get; set; }
    }
}