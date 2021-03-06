﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class HIF3eWOWDBEntities : DbContext
    {
        public HIF3eWOWDBEntities()
            : base("name=HIF3eWOWDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<achievement_criteria_requirement> achievement_criteria_requirement { get; set; }
        public virtual DbSet<achievement_reward> achievement_reward { get; set; }
        public virtual DbSet<areatrigger_involvedrelation> areatrigger_involvedrelation { get; set; }
        public virtual DbSet<areatrigger_tavern> areatrigger_tavern { get; set; }
        public virtual DbSet<areatrigger_teleport> areatrigger_teleport { get; set; }
        public virtual DbSet<auction> auctions { get; set; }
        public virtual DbSet<battleground_events> battleground_events { get; set; }
        public virtual DbSet<battleground_template> battleground_template { get; set; }
        public virtual DbSet<battlemaster_entry> battlemaster_entry { get; set; }
        public virtual DbSet<bugreport> bugreports { get; set; }
        public virtual DbSet<command> commands { get; set; }
        public virtual DbSet<condition> conditions { get; set; }
        public virtual DbSet<creature> creatures { get; set; }
        public virtual DbSet<creature_addon> creature_addon { get; set; }
        public virtual DbSet<creature_ai_scripts> creature_ai_scripts { get; set; }
        public virtual DbSet<creature_ai_summons> creature_ai_summons { get; set; }
        public virtual DbSet<creature_ai_texts> creature_ai_texts { get; set; }
        public virtual DbSet<creature_battleground> creature_battleground { get; set; }
        public virtual DbSet<creature_conditional_spawn> creature_conditional_spawn { get; set; }
        public virtual DbSet<creature_cooldowns> creature_cooldowns { get; set; }
        public virtual DbSet<creature_equip_template> creature_equip_template { get; set; }
        public virtual DbSet<creature_equip_template_raw> creature_equip_template_raw { get; set; }
        public virtual DbSet<creature_involvedrelation> creature_involvedrelation { get; set; }
        public virtual DbSet<creature_linking> creature_linking { get; set; }
        public virtual DbSet<creature_linking_template> creature_linking_template { get; set; }
        public virtual DbSet<creature_loot_template> creature_loot_template { get; set; }
        public virtual DbSet<creature_loot_template_ref> creature_loot_template_ref { get; set; }
        public virtual DbSet<creature_model_info> creature_model_info { get; set; }
        public virtual DbSet<creature_model_race> creature_model_race { get; set; }
        public virtual DbSet<creature_movement> creature_movement { get; set; }
        public virtual DbSet<creature_movement_template> creature_movement_template { get; set; }
        public virtual DbSet<creature_onkill_reputation> creature_onkill_reputation { get; set; }
        public virtual DbSet<creature_questrelation> creature_questrelation { get; set; }
        public virtual DbSet<creature_spawn_entry> creature_spawn_entry { get; set; }
        public virtual DbSet<creature_template> creature_template { get; set; }
        public virtual DbSet<creature_template_addon> creature_template_addon { get; set; }
        public virtual DbSet<creature_template_armor> creature_template_armor { get; set; }
        public virtual DbSet<creature_template_classlevelstats> creature_template_classlevelstats { get; set; }
        public virtual DbSet<creature_template_classlevelstats_exp0> creature_template_classlevelstats_exp0 { get; set; }
        public virtual DbSet<creature_template_spells> creature_template_spells { get; set; }
        public virtual DbSet<custom_texts> custom_texts { get; set; }
        public virtual DbSet<dbscript_random_templates> dbscript_random_templates { get; set; }
        public virtual DbSet<dbscript_string> dbscript_string { get; set; }
        public virtual DbSet<disenchant_loot_template> disenchant_loot_template { get; set; }
        public virtual DbSet<exploration_basexp> exploration_basexp { get; set; }
        public virtual DbSet<fishing_loot_template> fishing_loot_template { get; set; }
        public virtual DbSet<game_event> game_event { get; set; }
        public virtual DbSet<game_event_creature> game_event_creature { get; set; }
        public virtual DbSet<game_event_creature_data> game_event_creature_data { get; set; }
        public virtual DbSet<game_event_gameobject> game_event_gameobject { get; set; }
        public virtual DbSet<game_event_mail> game_event_mail { get; set; }
        public virtual DbSet<game_event_quest> game_event_quest { get; set; }
        public virtual DbSet<game_graveyard_zone> game_graveyard_zone { get; set; }
        public virtual DbSet<game_tele> game_tele { get; set; }
        public virtual DbSet<game_weather> game_weather { get; set; }
        public virtual DbSet<gameobject> gameobjects { get; set; }
        public virtual DbSet<gameobject_addon> gameobject_addon { get; set; }
        public virtual DbSet<gameobject_battleground> gameobject_battleground { get; set; }
        public virtual DbSet<gameobject_involvedrelation> gameobject_involvedrelation { get; set; }
        public virtual DbSet<gameobject_loot_template> gameobject_loot_template { get; set; }
        public virtual DbSet<gameobject_questrelation> gameobject_questrelation { get; set; }
        public virtual DbSet<gameobject_template> gameobject_template { get; set; }
        public virtual DbSet<gossip_menu> gossip_menu { get; set; }
        public virtual DbSet<gossip_menu_option> gossip_menu_option { get; set; }
        public virtual DbSet<gossip_texts> gossip_texts { get; set; }
        public virtual DbSet<instance_dungeon_encounters> instance_dungeon_encounters { get; set; }
        public virtual DbSet<instance_encounters> instance_encounters { get; set; }
        public virtual DbSet<instance_template> instance_template { get; set; }
        public virtual DbSet<item_convert> item_convert { get; set; }
        public virtual DbSet<item_enchantment_template> item_enchantment_template { get; set; }
        public virtual DbSet<item_expire_convert> item_expire_convert { get; set; }
        public virtual DbSet<item_loot_template> item_loot_template { get; set; }
        public virtual DbSet<item_template> item_template { get; set; }
        public virtual DbSet<mail_level_reward> mail_level_reward { get; set; }
        public virtual DbSet<mail_loot_template> mail_loot_template { get; set; }
        public virtual DbSet<mangos_string> mangos_string { get; set; }
        public virtual DbSet<milling_loot_template> milling_loot_template { get; set; }
        public virtual DbSet<npc_gossip> npc_gossip { get; set; }
        public virtual DbSet<npc_text> npc_text { get; set; }
        public virtual DbSet<npc_vendor> npc_vendor { get; set; }
        public virtual DbSet<npc_vendor_template> npc_vendor_template { get; set; }
        public virtual DbSet<page_text> page_text { get; set; }
        public virtual DbSet<pet_familystats> pet_familystats { get; set; }
        public virtual DbSet<pet_levelstats> pet_levelstats { get; set; }
        public virtual DbSet<pet_levelstats_copy> pet_levelstats_copy { get; set; }
        public virtual DbSet<pet_name_generation> pet_name_generation { get; set; }
        public virtual DbSet<petcreateinfo_spell> petcreateinfo_spell { get; set; }
        public virtual DbSet<pickpocketing_loot_template> pickpocketing_loot_template { get; set; }
        public virtual DbSet<player_classlevelstats> player_classlevelstats { get; set; }
        public virtual DbSet<player_levelstats> player_levelstats { get; set; }
        public virtual DbSet<player_xp_for_level> player_xp_for_level { get; set; }
        public virtual DbSet<playercreateinfo> playercreateinfoes { get; set; }
        public virtual DbSet<playercreateinfo_action> playercreateinfo_action { get; set; }
        public virtual DbSet<playercreateinfo_skills> playercreateinfo_skills { get; set; }
        public virtual DbSet<playercreateinfo_spell> playercreateinfo_spell { get; set; }
        public virtual DbSet<points_of_interest> points_of_interest { get; set; }
        public virtual DbSet<pool_creature> pool_creature { get; set; }
        public virtual DbSet<pool_creature_template> pool_creature_template { get; set; }
        public virtual DbSet<pool_gameobject> pool_gameobject { get; set; }
        public virtual DbSet<pool_gameobject_template> pool_gameobject_template { get; set; }
        public virtual DbSet<pool_pool> pool_pool { get; set; }
        public virtual DbSet<pool_template> pool_template { get; set; }
        public virtual DbSet<prospecting_loot_template> prospecting_loot_template { get; set; }
        public virtual DbSet<quest_poi> quest_poi { get; set; }
        public virtual DbSet<quest_template> quest_template { get; set; }
        public virtual DbSet<questgiver_greeting> questgiver_greeting { get; set; }
        public virtual DbSet<reference_loot_template> reference_loot_template { get; set; }
        public virtual DbSet<reference_loot_template_names> reference_loot_template_names { get; set; }
        public virtual DbSet<reference_loot_template_ref> reference_loot_template_ref { get; set; }
        public virtual DbSet<reputation_reward_rate> reputation_reward_rate { get; set; }
        public virtual DbSet<reputation_spillover_template> reputation_spillover_template { get; set; }
        public virtual DbSet<reserved_name> reserved_name { get; set; }
        public virtual DbSet<script_texts> script_texts { get; set; }
        public virtual DbSet<script_waypoint> script_waypoint { get; set; }
        public virtual DbSet<scripted_areatrigger> scripted_areatrigger { get; set; }
        public virtual DbSet<scripted_event_id> scripted_event_id { get; set; }
        public virtual DbSet<skill_discovery_template> skill_discovery_template { get; set; }
        public virtual DbSet<skill_extra_item_template> skill_extra_item_template { get; set; }
        public virtual DbSet<skill_fishing_base_level> skill_fishing_base_level { get; set; }
        public virtual DbSet<skinning_loot_template> skinning_loot_template { get; set; }
        public virtual DbSet<spam_records> spam_records { get; set; }
        public virtual DbSet<spell_affect> spell_affect { get; set; }
        public virtual DbSet<spell_area> spell_area { get; set; }
        public virtual DbSet<spell_bonus_data> spell_bonus_data { get; set; }
        public virtual DbSet<spell_chain> spell_chain { get; set; }
        public virtual DbSet<spell_cone> spell_cone { get; set; }
        public virtual DbSet<spell_elixir> spell_elixir { get; set; }
        public virtual DbSet<spell_facing> spell_facing { get; set; }
        public virtual DbSet<spell_learn_spell> spell_learn_spell { get; set; }
        public virtual DbSet<spell_loot_template> spell_loot_template { get; set; }
        public virtual DbSet<spell_pet_auras> spell_pet_auras { get; set; }
        public virtual DbSet<spell_proc_event> spell_proc_event { get; set; }
        public virtual DbSet<spell_proc_item_enchant> spell_proc_item_enchant { get; set; }
        public virtual DbSet<spell_target_position> spell_target_position { get; set; }
        public virtual DbSet<spell_template> spell_template { get; set; }
        public virtual DbSet<spell_threat> spell_threat { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<taxi_shortcuts> taxi_shortcuts { get; set; }
        public virtual DbSet<trainer_greeting> trainer_greeting { get; set; }
        public virtual DbSet<transport> transports { get; set; }
        public virtual DbSet<vehicle_accessory> vehicle_accessory { get; set; }
        public virtual DbSet<world_template> world_template { get; set; }
        public virtual DbSet<dbscripts_on_creature_death> dbscripts_on_creature_death { get; set; }
        public virtual DbSet<dbscripts_on_creature_movement> dbscripts_on_creature_movement { get; set; }
        public virtual DbSet<dbscripts_on_event> dbscripts_on_event { get; set; }
        public virtual DbSet<dbscripts_on_go_template_use> dbscripts_on_go_template_use { get; set; }
        public virtual DbSet<dbscripts_on_go_use> dbscripts_on_go_use { get; set; }
        public virtual DbSet<dbscripts_on_gossip> dbscripts_on_gossip { get; set; }
        public virtual DbSet<dbscripts_on_quest_end> dbscripts_on_quest_end { get; set; }
        public virtual DbSet<dbscripts_on_quest_start> dbscripts_on_quest_start { get; set; }
        public virtual DbSet<dbscripts_on_relay> dbscripts_on_relay { get; set; }
        public virtual DbSet<dbscripts_on_spell> dbscripts_on_spell { get; set; }
        public virtual DbSet<item_required_target> item_required_target { get; set; }
        public virtual DbSet<npc_spellclick_spells> npc_spellclick_spells { get; set; }
        public virtual DbSet<npc_trainer> npc_trainer { get; set; }
        public virtual DbSet<npc_trainer_template> npc_trainer_template { get; set; }
        public virtual DbSet<playercreateinfo_item> playercreateinfo_item { get; set; }
        public virtual DbSet<quest_poi_points> quest_poi_points { get; set; }
        public virtual DbSet<spell_script_target> spell_script_target { get; set; }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    }
}
