//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Butcamp2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TB_M_Items
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_M_Items()
        {
            this.TB_T_TransactionItem = new HashSet<TB_T_TransactionItem>();
        }
    
        public int Id { get; set; }
        public string name { get; set; }
        public Nullable<int> Suppliers_Id { get; set; }
        public bool isDelete { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<int> Stock { get; set; }
    
        public virtual TB_M_Supplier TB_M_Supplier { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_T_TransactionItem> TB_T_TransactionItem { get; set; }
    }
}
