//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RecipSuggestor.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class RITab
    {
        public int RIId { get; set; }
        public int RecId { get; set; }
        public int IngId { get; set; }
    
        public virtual IngredientTab IngredientTab { get; set; }
        public virtual RecipeTab RecipeTab { get; set; }
    }
}
