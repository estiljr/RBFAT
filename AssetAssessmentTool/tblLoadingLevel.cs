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
    
    public partial class tblLoadingLevel
    {
        public int ObjectID { get; set; }
        public Nullable<int> LoadingLocationID { get; set; }
        public Nullable<int> LoadingScenarioID { get; set; }
        public Nullable<int> ReturnPeriod { get; set; }
        public Nullable<float> WaterLevel { get; set; }
    
        public virtual tblLoadingLocation tblLoadingLocation { get; set; }
        public virtual tblLoadingScenario tblLoadingScenario { get; set; }
    }
}