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
    
    public partial class tlkpConditionGrade
    {
        public tlkpConditionGrade()
        {
            this.tblAssets = new HashSet<tblAsset>();
            this.tlkpFragilityCurves = new HashSet<tlkpFragilityCurve>();
        }
    
        public Nullable<int> ObjectID { get; set; }
        public string ConditionGrade { get; set; }
    
        public virtual ICollection<tblAsset> tblAssets { get; set; }
        public virtual ICollection<tlkpFragilityCurve> tlkpFragilityCurves { get; set; }
    }
}
