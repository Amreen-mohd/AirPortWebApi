//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AirPortWebApi.Models
{
    using System;
    
    public partial class GetAvailablePlanes_Result
    {
        public string PlaneId { get; set; }
        public string ManufacturerName { get; set; }
        public string RegNo { get; set; }
        public string ModelNo { get; set; }
        public string PlaneName { get; set; }
        public Nullable<int> Capacity { get; set; }
        public Nullable<int> OwnerId { get; set; }
        public Nullable<int> Id { get; set; }
    }
}
