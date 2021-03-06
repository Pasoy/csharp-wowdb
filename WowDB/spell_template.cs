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
    
    public partial class spell_template
    {
        public long Id { get; set; }
        public long School { get; set; }
        public long Category { get; set; }
        public long CastUI { get; set; }
        public long Dispel { get; set; }
        public long Mechanic { get; set; }
        public long Attributes { get; set; }
        public long AttributesEx { get; set; }
        public long AttributesEx2 { get; set; }
        public long AttributesEx3 { get; set; }
        public long AttributesEx4 { get; set; }
        public long Stances { get; set; }
        public long StancesNot { get; set; }
        public long Targets { get; set; }
        public long TargetCreatureType { get; set; }
        public long RequiresSpellFocus { get; set; }
        public long CasterAuraState { get; set; }
        public long TargetAuraState { get; set; }
        public long CastingTimeIndex { get; set; }
        public long RecoveryTime { get; set; }
        public long CategoryRecoveryTime { get; set; }
        public long InterruptFlags { get; set; }
        public long AuraInterruptFlags { get; set; }
        public long ChannelInterruptFlags { get; set; }
        public long ProcFlags { get; set; }
        public long ProcChance { get; set; }
        public long ProcCharges { get; set; }
        public long MaxLevel { get; set; }
        public long BaseLevel { get; set; }
        public long SpellLevel { get; set; }
        public long DurationIndex { get; set; }
        public long PowerType { get; set; }
        public long ManaCost { get; set; }
        public long ManaCostPerlevel { get; set; }
        public long ManaPerSecond { get; set; }
        public long ManaPerSecondPerLevel { get; set; }
        public long RangeIndex { get; set; }
        public float Speed { get; set; }
        public long ModalNextSpell { get; set; }
        public long StackAmount { get; set; }
        public long Totem1 { get; set; }
        public long Totem2 { get; set; }
        public int Reagent1 { get; set; }
        public int Reagent2 { get; set; }
        public int Reagent3 { get; set; }
        public int Reagent4 { get; set; }
        public int Reagent5 { get; set; }
        public int Reagent6 { get; set; }
        public int Reagent7 { get; set; }
        public int Reagent8 { get; set; }
        public long ReagentCount1 { get; set; }
        public long ReagentCount2 { get; set; }
        public long ReagentCount3 { get; set; }
        public long ReagentCount4 { get; set; }
        public long ReagentCount5 { get; set; }
        public long ReagentCount6 { get; set; }
        public long ReagentCount7 { get; set; }
        public long ReagentCount8 { get; set; }
        public int EquippedItemClass { get; set; }
        public int EquippedItemSubClassMask { get; set; }
        public int EquippedItemInventoryTypeMask { get; set; }
        public long Effect1 { get; set; }
        public long Effect2 { get; set; }
        public long Effect3 { get; set; }
        public int EffectDieSides1 { get; set; }
        public int EffectDieSides2 { get; set; }
        public int EffectDieSides3 { get; set; }
        public long EffectBaseDice1 { get; set; }
        public long EffectBaseDice2 { get; set; }
        public long EffectBaseDice3 { get; set; }
        public float EffectDicePerLevel1 { get; set; }
        public float EffectDicePerLevel2 { get; set; }
        public float EffectDicePerLevel3 { get; set; }
        public float EffectRealPointsPerLevel1 { get; set; }
        public float EffectRealPointsPerLevel2 { get; set; }
        public float EffectRealPointsPerLevel3 { get; set; }
        public int EffectBasePoints1 { get; set; }
        public int EffectBasePoints2 { get; set; }
        public int EffectBasePoints3 { get; set; }
        public long EffectMechanic1 { get; set; }
        public long EffectMechanic2 { get; set; }
        public long EffectMechanic3 { get; set; }
        public long EffectImplicitTargetA1 { get; set; }
        public long EffectImplicitTargetA2 { get; set; }
        public long EffectImplicitTargetA3 { get; set; }
        public long EffectImplicitTargetB1 { get; set; }
        public long EffectImplicitTargetB2 { get; set; }
        public long EffectImplicitTargetB3 { get; set; }
        public long EffectRadiusIndex1 { get; set; }
        public long EffectRadiusIndex2 { get; set; }
        public long EffectRadiusIndex3 { get; set; }
        public long EffectApplyAuraName1 { get; set; }
        public long EffectApplyAuraName2 { get; set; }
        public long EffectApplyAuraName3 { get; set; }
        public long EffectAmplitude1 { get; set; }
        public long EffectAmplitude2 { get; set; }
        public long EffectAmplitude3 { get; set; }
        public float EffectMultipleValue1 { get; set; }
        public float EffectMultipleValue2 { get; set; }
        public float EffectMultipleValue3 { get; set; }
        public long EffectChainTarget1 { get; set; }
        public long EffectChainTarget2 { get; set; }
        public long EffectChainTarget3 { get; set; }
        public long EffectItemType1 { get; set; }
        public long EffectItemType2 { get; set; }
        public long EffectItemType3 { get; set; }
        public int EffectMiscValue1 { get; set; }
        public int EffectMiscValue2 { get; set; }
        public int EffectMiscValue3 { get; set; }
        public long EffectTriggerSpell1 { get; set; }
        public long EffectTriggerSpell2 { get; set; }
        public long EffectTriggerSpell3 { get; set; }
        public float EffectPointsPerComboPoint1 { get; set; }
        public float EffectPointsPerComboPoint2 { get; set; }
        public float EffectPointsPerComboPoint3 { get; set; }
        public long SpellVisual { get; set; }
        public long SpellIconID { get; set; }
        public long ActiveIconID { get; set; }
        public long SpellPriority { get; set; }
        public string SpellName { get; set; }
        public string SpellName2 { get; set; }
        public string SpellName3 { get; set; }
        public string SpellName4 { get; set; }
        public string SpellName5 { get; set; }
        public string SpellName6 { get; set; }
        public string SpellName7 { get; set; }
        public string SpellName8 { get; set; }
        public string Rank { get; set; }
        public string Rank2 { get; set; }
        public string Rank3 { get; set; }
        public string Rank4 { get; set; }
        public string Rank5 { get; set; }
        public string Rank6 { get; set; }
        public string Rank7 { get; set; }
        public string Rank8 { get; set; }
        public long ManaCostPercentage { get; set; }
        public long StartRecoveryCategory { get; set; }
        public long StartRecoveryTime { get; set; }
        public long MaxTargetLevel { get; set; }
        public long SpellFamilyName { get; set; }
        public long SpellFamilyFlags { get; set; }
        public long MaxAffectedTargets { get; set; }
        public long DmgClass { get; set; }
        public long PreventionType { get; set; }
        public int StanceBarOrder { get; set; }
        public float DmgMultiplier1 { get; set; }
        public float DmgMultiplier2 { get; set; }
        public float DmgMultiplier3 { get; set; }
        public long MinFactionId { get; set; }
        public long MinReputation { get; set; }
        public long RequiredAuraVision { get; set; }
        public long IsServerSide { get; set; }
        public long AttributesServerside { get; set; }
    }
}
