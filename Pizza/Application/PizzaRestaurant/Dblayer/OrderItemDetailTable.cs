//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dblayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrderItemDetailTable
    {
        public int OrderItemDetailID { get; set; }
        public int OrderID { get; set; }
        public int StockItemID { get; set; }
        public int Qty { get; set; }
        public double UnitPrice { get; set; }
        public int DIscountID { get; set; }
        public double DiscountAmount { get; set; }
    
        public virtual DiscountTable DiscountTable { get; set; }
        public virtual OrderTable OrderTable { get; set; }
        public virtual StockItemTable StockItemTable { get; set; }
    }
}