//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FR.Repository
{
    using System;
    using System.Collections.Generic;
    
    public partial class fr_SideChoices
    {
        public int SideChoiceId { get; set; }
        public int ProductId { get; set; }
        public string Title { get; set; }
        public System.DateTime AddedDate { get; set; }
        public string AddedBy { get; set; }
        public System.DateTime UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public bool Active { get; set; }
    
        public virtual fr_Products fr_Products { get; set; }
    }
}
