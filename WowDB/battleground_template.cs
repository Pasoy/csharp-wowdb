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
    
    public partial class battleground_template
    {
        public decimal id { get; set; }
        public int MinPlayersPerTeam { get; set; }
        public int MaxPlayersPerTeam { get; set; }
        public byte MinLvl { get; set; }
        public byte MaxLvl { get; set; }
        public decimal AllianceStartLoc { get; set; }
        public float AllianceStartO { get; set; }
        public decimal HordeStartLoc { get; set; }
        public float HordeStartO { get; set; }
        public float StartMaxDist { get; set; }
    }
}
