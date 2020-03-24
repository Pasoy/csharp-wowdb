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
    
    public partial class quest_template
    {
        public decimal entry { get; set; }
        public byte Method { get; set; }
        public short ZoneOrSort { get; set; }
        public byte MinLevel { get; set; }
        public byte MaxLevel { get; set; }
        public short QuestLevel { get; set; }
        public int Type { get; set; }
        public int RequiredClasses { get; set; }
        public int RequiredRaces { get; set; }
        public int RequiredSkill { get; set; }
        public int RequiredSkillValue { get; set; }
        public long RequiredCondition { get; set; }
        public int RepObjectiveFaction { get; set; }
        public decimal RepObjectiveValue { get; set; }
        public int RequiredMinRepFaction { get; set; }
        public decimal RequiredMinRepValue { get; set; }
        public int RequiredMaxRepFaction { get; set; }
        public decimal RequiredMaxRepValue { get; set; }
        public byte SuggestedPlayers { get; set; }
        public long LimitTime { get; set; }
        public int QuestFlags { get; set; }
        public byte SpecialFlags { get; set; }
        public decimal PrevQuestId { get; set; }
        public decimal NextQuestId { get; set; }
        public decimal ExclusiveGroup { get; set; }
        public decimal NextQuestInChain { get; set; }
        public decimal SrcItemId { get; set; }
        public byte SrcItemCount { get; set; }
        public decimal SrcSpell { get; set; }
        public string Title { get; set; }
        public string Details { get; set; }
        public string Objectives { get; set; }
        public string OfferRewardText { get; set; }
        public string RequestItemsText { get; set; }
        public string EndText { get; set; }
        public string ObjectiveText1 { get; set; }
        public string ObjectiveText2 { get; set; }
        public string ObjectiveText3 { get; set; }
        public string ObjectiveText4 { get; set; }
        public decimal ReqItemId1 { get; set; }
        public decimal ReqItemId2 { get; set; }
        public decimal ReqItemId3 { get; set; }
        public decimal ReqItemId4 { get; set; }
        public int ReqItemCount1 { get; set; }
        public int ReqItemCount2 { get; set; }
        public int ReqItemCount3 { get; set; }
        public int ReqItemCount4 { get; set; }
        public decimal ReqSourceId1 { get; set; }
        public decimal ReqSourceId2 { get; set; }
        public decimal ReqSourceId3 { get; set; }
        public decimal ReqSourceId4 { get; set; }
        public int ReqSourceCount1 { get; set; }
        public int ReqSourceCount2 { get; set; }
        public int ReqSourceCount3 { get; set; }
        public int ReqSourceCount4 { get; set; }
        public decimal ReqCreatureOrGOId1 { get; set; }
        public decimal ReqCreatureOrGOId2 { get; set; }
        public decimal ReqCreatureOrGOId3 { get; set; }
        public decimal ReqCreatureOrGOId4 { get; set; }
        public int ReqCreatureOrGOCount1 { get; set; }
        public int ReqCreatureOrGOCount2 { get; set; }
        public int ReqCreatureOrGOCount3 { get; set; }
        public int ReqCreatureOrGOCount4 { get; set; }
        public decimal ReqSpellCast1 { get; set; }
        public decimal ReqSpellCast2 { get; set; }
        public decimal ReqSpellCast3 { get; set; }
        public decimal ReqSpellCast4 { get; set; }
        public decimal RewChoiceItemId1 { get; set; }
        public decimal RewChoiceItemId2 { get; set; }
        public decimal RewChoiceItemId3 { get; set; }
        public decimal RewChoiceItemId4 { get; set; }
        public decimal RewChoiceItemId5 { get; set; }
        public decimal RewChoiceItemId6 { get; set; }
        public int RewChoiceItemCount1 { get; set; }
        public int RewChoiceItemCount2 { get; set; }
        public int RewChoiceItemCount3 { get; set; }
        public int RewChoiceItemCount4 { get; set; }
        public int RewChoiceItemCount5 { get; set; }
        public int RewChoiceItemCount6 { get; set; }
        public decimal RewItemId1 { get; set; }
        public decimal RewItemId2 { get; set; }
        public decimal RewItemId3 { get; set; }
        public decimal RewItemId4 { get; set; }
        public int RewItemCount1 { get; set; }
        public int RewItemCount2 { get; set; }
        public int RewItemCount3 { get; set; }
        public int RewItemCount4 { get; set; }
        public int RewRepFaction1 { get; set; }
        public int RewRepFaction2 { get; set; }
        public int RewRepFaction3 { get; set; }
        public int RewRepFaction4 { get; set; }
        public int RewRepFaction5 { get; set; }
        public decimal RewRepValue1 { get; set; }
        public decimal RewRepValue2 { get; set; }
        public decimal RewRepValue3 { get; set; }
        public decimal RewRepValue4 { get; set; }
        public decimal RewRepValue5 { get; set; }
        public int RewOrReqMoney { get; set; }
        public long RewMoneyMaxLevel { get; set; }
        public decimal RewSpell { get; set; }
        public decimal RewSpellCast { get; set; }
        public decimal RewMailTemplateId { get; set; }
        public long RewMailDelaySecs { get; set; }
        public int PointMapId { get; set; }
        public float PointX { get; set; }
        public float PointY { get; set; }
        public decimal PointOpt { get; set; }
        public int DetailsEmote1 { get; set; }
        public int DetailsEmote2 { get; set; }
        public int DetailsEmote3 { get; set; }
        public int DetailsEmote4 { get; set; }
        public long DetailsEmoteDelay1 { get; set; }
        public long DetailsEmoteDelay2 { get; set; }
        public long DetailsEmoteDelay3 { get; set; }
        public long DetailsEmoteDelay4 { get; set; }
        public int IncompleteEmote { get; set; }
        public long IncompleteEmoteDelay { get; set; }
        public int CompleteEmote { get; set; }
        public long CompleteEmoteDelay { get; set; }
        public int OfferRewardEmote1 { get; set; }
        public int OfferRewardEmote2 { get; set; }
        public int OfferRewardEmote3 { get; set; }
        public int OfferRewardEmote4 { get; set; }
        public long OfferRewardEmoteDelay1 { get; set; }
        public long OfferRewardEmoteDelay2 { get; set; }
        public long OfferRewardEmoteDelay3 { get; set; }
        public long OfferRewardEmoteDelay4 { get; set; }
        public decimal StartScript { get; set; }
        public decimal CompleteScript { get; set; }
    }
}