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
    
    public partial class spell_proc_event
    {
        public decimal entry { get; set; }
        public byte SchoolMask { get; set; }
        public int SpellFamilyName { get; set; }
        public long SpellFamilyMask0 { get; set; }
        public long SpellFamilyMask1 { get; set; }
        public long SpellFamilyMask2 { get; set; }
        public long procFlags { get; set; }
        public long procEx { get; set; }
        public float ppmRate { get; set; }
        public float CustomChance { get; set; }
        public long Cooldown { get; set; }
    }
}
