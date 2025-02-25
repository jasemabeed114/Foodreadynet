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
    
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            this.AddSides = new HashSet<AddSide>();
            this.CheeseAmounts = new HashSet<CheeseAmount>();
            this.CrustChoices = new HashSet<CrustChoice>();
            this.FamilyMeals = new HashSet<FamilyMeal>();
            this.OrderItems = new HashSet<OrderItem>();
            this.ProductDressings = new HashSet<ProductDressing>();
            this.ProductSizes = new HashSet<ProductSize>();
            this.ProductToppings = new HashSet<ProductTopping>();
            this.SauceChoices = new HashSet<SauceChoice>();
            this.SideChoices = new HashSet<SideChoice>();
        }
    
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public int CookMethodId { get; set; }
        public int FoodTypeId { get; set; }
        public int MealSectionId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal BizPrice { get; set; }
        public int DiscountPercentage { get; set; }
        public string SmallImage { get; set; }
        public string BigImage { get; set; }
        public int MaxNumOfFreeTopping { get; set; }
        public bool IsSpicy { get; set; }
        public bool IsVegetarian { get; set; }
        public bool IsMostPopular { get; set; }
        public bool IsFamilyDinner { get; set; }
        public System.DateTime AddedDate { get; set; }
        public string AddedBy { get; set; }
        public System.DateTime UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public bool Active { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AddSide> AddSides { get; set; }
        public virtual Category Category { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CheeseAmount> CheeseAmounts { get; set; }
        public virtual CookMethod CookMethod { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CrustChoice> CrustChoices { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FamilyMeal> FamilyMeals { get; set; }
        public virtual FoodType FoodType { get; set; }
        public virtual MealSection MealSection { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderItem> OrderItems { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductDressing> ProductDressings { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductSize> ProductSizes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductTopping> ProductToppings { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SauceChoice> SauceChoices { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SideChoice> SideChoices { get; set; }
    }
}
