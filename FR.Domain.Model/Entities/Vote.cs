//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FR.Domain.Model.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Vote
    {
        public int VoteId { get; set; }
        public int BizInfoId { get; set; }
        public string Title { get; set; }
        public string PenName { get; set; }
        public string UserId { get; set; }
        public int RatingVote { get; set; }
        public string IpAddress { get; set; }
        public string Comment { get; set; }
        public System.DateTime AddedDate { get; set; }
        public string AddedBy { get; set; }
        public System.DateTime UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public bool Active { get; set; }
    
        public virtual AspNetUser AspNetUser { get; set; }
        public virtual BizInfo BizInfo { get; set; }
    }
}
