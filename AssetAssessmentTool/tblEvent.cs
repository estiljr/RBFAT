//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AssetAssessmentTool
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblEvent
    {
        public tblEvent()
        {
            this.tblEventSettings = new HashSet<tblEventSetting>();
        }
    
        public int EventID { get; set; }
        public string Description { get; set; }
        public Nullable<bool> Included { get; set; }
        public string OutputType { get; set; }
        public string Output { get; set; }
        public string EventDamage { get; set; }
    
        public virtual ICollection<tblEventSetting> tblEventSettings { get; set; }
    }
}
