//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Diagram
{
    using System;
    using System.Collections.Generic;
    
    public partial class Chapter
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Chapter()
        {
            this.Users = new HashSet<User>();
        }
    
        public System.Guid IdChapter { get; set; }
        public string TitleChap { get; set; }
        public string IdStory { get; set; }
        public string Collector { get; set; }
        public System.DateTime CreateDate { get; set; }
        public string Content { get; set; }
    
        public virtual Story Story { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<User> Users { get; set; }
    }
}