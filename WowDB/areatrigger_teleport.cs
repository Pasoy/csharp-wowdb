//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WowDB
{
    using System;
    using System.Collections.Generic;
    
    public partial class areatrigger_teleport
    {
        public decimal id { get; set; }
        public string name { get; set; }
        public byte required_level { get; set; }
        public decimal required_item { get; set; }
        public decimal required_item2 { get; set; }
        public long required_quest_done { get; set; }
        public int target_map { get; set; }
        public float target_position_x { get; set; }
        public float target_position_y { get; set; }
        public float target_position_z { get; set; }
        public float target_orientation { get; set; }
        public string status_failed_text { get; set; }
        public long condition_id { get; set; }
    }
}
