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
    
    public partial class fr_OrderItems
    {
        public int OrderItemId { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public string Title { get; set; }
        public bool IsFamilyMeal { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal FinalSalePrice { get; set; }
        public decimal BizUnitPrice { get; set; }
        public decimal BizFinalPrice { get; set; }
        public int DiscountPercentage { get; set; }
        public int Quantity { get; set; }
        public decimal ExtraListTotal { get; set; }
        public string ProductSizeTitle { get; set; }
        public string ProductSize { get; set; }
        public decimal ProductSizePrice { get; set; }
        public decimal BizSizePrice { get; set; }
        public string HowSpicy { get; set; }
        public string SideChoice { get; set; }
        public string SauceChoice { get; set; }
        public string SelectedFreeToppings { get; set; }
        public string DressingChoice { get; set; }
        public string SelectedToppings { get; set; }
        public string SelectedAddSides { get; set; }
        public decimal AddSideListPrice { get; set; }
        public decimal BizAddSideListPrice { get; set; }
        public string CrustChoice { get; set; }
        public decimal CrustChoicePrice { get; set; }
        public decimal CrustChoiceBizPrice { get; set; }
        public string CheeseAmount { get; set; }
        public decimal cheeseAmountPrice { get; set; }
        public decimal CheeseAmountBizPrice { get; set; }
        public string Instruction { get; set; }
        public decimal BizItemTotal { get; set; }
        public decimal ItemTotal { get; set; }
        public System.DateTime AddedDate { get; set; }
        public string AddedBy { get; set; }
        public System.DateTime UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public bool Active { get; set; }
    
        public virtual fr_Orders fr_Orders { get; set; }
        public virtual fr_Products fr_Products { get; set; }
    }
}
