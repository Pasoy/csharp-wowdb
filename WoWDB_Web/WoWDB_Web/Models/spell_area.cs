//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WoWDB_Web.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class spell_area
    {
        public decimal spell { get; set; }
        public decimal area { get; set; }
        public decimal quest_start { get; set; }
        public byte quest_start_active { get; set; }
        public decimal quest_end { get; set; }
        public decimal condition_id { get; set; }
        public decimal aura_spell { get; set; }
        public decimal racemask { get; set; }
        public byte gender { get; set; }
        public byte autocast { get; set; }
    }
}
