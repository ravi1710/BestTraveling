//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BT_Data.BT_EDMX
{
    using System;
    using System.Collections.Generic;
    
    public partial class bt_City
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public bt_City()
        {
            this.bt_College = new HashSet<bt_College>();
        }
    
        public System.Guid CityId { get; set; }
        public string Name { get; set; }
        public Nullable<System.Guid> DistrictId { get; set; }
    
        public virtual bt_District bt_District { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<bt_College> bt_College { get; set; }
    }
}