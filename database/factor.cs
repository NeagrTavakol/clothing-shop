//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace foroshgahlebas.database
{
    using System;
    using System.Collections.Generic;
    
    public partial class factor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public factor()
        {
            this.dress_factor = new HashSet<dress_factor>();
        }
    
        public int id { get; set; }
        public int customerid { get; set; }
        public System.DateTime date { get; set; }
        public long payment { get; set; }
    
        public virtual customer customer { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dress_factor> dress_factor { get; set; }
    }
}
