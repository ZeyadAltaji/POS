//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace POS
{
    using System;
    using System.Collections.Generic;
    
    public partial class TB_supp
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_supp()
        {
            this.TB_Pur = new HashSet<TB_Pur>();
        }
    
        public int ID_supp { get; set; }
        public string Name_supp { get; set; }
        public string Phone_supp { get; set; }
        public string Email_supp { get; set; }
        public string Sex_supp { get; set; }
        public byte[] img_supp { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_Pur> TB_Pur { get; set; }
    }
}
