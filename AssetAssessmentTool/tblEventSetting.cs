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
    
    public partial class tblEventSetting
    {
        public int ID { get; set; }
        public Nullable<int> EventID { get; set; }
        public Nullable<int> AssetID { get; set; }
        public string FailureMode { get; set; }
        public Nullable<float> WaterLevel { get; set; }
    
        public virtual tblAsset tblAsset { get; set; }
        public virtual tblEvent tblEvent { get; set; }
    }
}
