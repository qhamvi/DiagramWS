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
    
    public partial class Comment
    {
        public string IdComment { get; set; }
        public System.Guid IdUser { get; set; }
        public string IdStory { get; set; }
        public string Content { get; set; }
        public System.DateTime DateCom { get; set; }
        public System.DateTime UpdateCom { get; set; }
    
        public virtual Story Story { get; set; }
        public virtual User User { get; set; }
    }
}
