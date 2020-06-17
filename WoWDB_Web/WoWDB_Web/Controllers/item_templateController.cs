using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WoWDB_Web.Models;

namespace WoWDB_Web.Controllers
{
    public class item_templateController : Controller
    {
        private HIF3eWOWDBEntities db = new HIF3eWOWDBEntities();

        // GET: item_template
        public ActionResult Index()
        {
            return View(db.item_template.ToList());
        }

        // GET: item_template/Details/5
        public ActionResult Details(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            item_template item_template = db.item_template.Find(id);
            if (item_template == null)
            {
                return HttpNotFound();
            }
            return View(item_template);
        }

        // GET: item_template/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: item_template/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "entry,class,subclass,name,displayid,Quality,Flags,BuyCount,BuyPrice,SellPrice,InventoryType,AllowableClass,AllowableRace,ItemLevel,RequiredLevel,RequiredSkill,RequiredSkillRank,requiredspell,requiredhonorrank,RequiredCityRank,RequiredReputationFaction,RequiredReputationRank,maxcount,stackable,ContainerSlots,stat_type1,stat_value1,stat_type2,stat_value2,stat_type3,stat_value3,stat_type4,stat_value4,stat_type5,stat_value5,stat_type6,stat_value6,stat_type7,stat_value7,stat_type8,stat_value8,stat_type9,stat_value9,stat_type10,stat_value10,dmg_min1,dmg_max1,dmg_type1,dmg_min2,dmg_max2,dmg_type2,dmg_min3,dmg_max3,dmg_type3,dmg_min4,dmg_max4,dmg_type4,dmg_min5,dmg_max5,dmg_type5,armor,holy_res,fire_res,nature_res,frost_res,shadow_res,arcane_res,delay,ammo_type,RangedModRange,spellid_1,spelltrigger_1,spellcharges_1,spellppmRate_1,spellcooldown_1,spellcategory_1,spellcategorycooldown_1,spellid_2,spelltrigger_2,spellcharges_2,spellppmRate_2,spellcooldown_2,spellcategory_2,spellcategorycooldown_2,spellid_3,spelltrigger_3,spellcharges_3,spellppmRate_3,spellcooldown_3,spellcategory_3,spellcategorycooldown_3,spellid_4,spelltrigger_4,spellcharges_4,spellppmRate_4,spellcooldown_4,spellcategory_4,spellcategorycooldown_4,spellid_5,spelltrigger_5,spellcharges_5,spellppmRate_5,spellcooldown_5,spellcategory_5,spellcategorycooldown_5,bonding,description,PageText,LanguageID,PageMaterial,startquest,lockid,Material,sheath,RandomProperty,block,itemset,MaxDurability,area,Map,BagFamily,ScriptName,DisenchantID,FoodType,minMoneyLoot,maxMoneyLoot,Duration,ExtraFlags")] item_template item_template)
        {
            if (ModelState.IsValid)
            {
                db.item_template.Add(item_template);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(item_template);
        }

        // GET: item_template/Edit/5
        public ActionResult Edit(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            item_template item_template = db.item_template.Find(id);
            if (item_template == null)
            {
                return HttpNotFound();
            }
            return View(item_template);
        }

        // POST: item_template/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "entry,class,subclass,name,displayid,Quality,Flags,BuyCount,BuyPrice,SellPrice,InventoryType,AllowableClass,AllowableRace,ItemLevel,RequiredLevel,RequiredSkill,RequiredSkillRank,requiredspell,requiredhonorrank,RequiredCityRank,RequiredReputationFaction,RequiredReputationRank,maxcount,stackable,ContainerSlots,stat_type1,stat_value1,stat_type2,stat_value2,stat_type3,stat_value3,stat_type4,stat_value4,stat_type5,stat_value5,stat_type6,stat_value6,stat_type7,stat_value7,stat_type8,stat_value8,stat_type9,stat_value9,stat_type10,stat_value10,dmg_min1,dmg_max1,dmg_type1,dmg_min2,dmg_max2,dmg_type2,dmg_min3,dmg_max3,dmg_type3,dmg_min4,dmg_max4,dmg_type4,dmg_min5,dmg_max5,dmg_type5,armor,holy_res,fire_res,nature_res,frost_res,shadow_res,arcane_res,delay,ammo_type,RangedModRange,spellid_1,spelltrigger_1,spellcharges_1,spellppmRate_1,spellcooldown_1,spellcategory_1,spellcategorycooldown_1,spellid_2,spelltrigger_2,spellcharges_2,spellppmRate_2,spellcooldown_2,spellcategory_2,spellcategorycooldown_2,spellid_3,spelltrigger_3,spellcharges_3,spellppmRate_3,spellcooldown_3,spellcategory_3,spellcategorycooldown_3,spellid_4,spelltrigger_4,spellcharges_4,spellppmRate_4,spellcooldown_4,spellcategory_4,spellcategorycooldown_4,spellid_5,spelltrigger_5,spellcharges_5,spellppmRate_5,spellcooldown_5,spellcategory_5,spellcategorycooldown_5,bonding,description,PageText,LanguageID,PageMaterial,startquest,lockid,Material,sheath,RandomProperty,block,itemset,MaxDurability,area,Map,BagFamily,ScriptName,DisenchantID,FoodType,minMoneyLoot,maxMoneyLoot,Duration,ExtraFlags")] item_template item_template)
        {
            if (ModelState.IsValid)
            {
                db.Entry(item_template).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(item_template);
        }

        // GET: item_template/Delete/5
        public ActionResult Delete(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            item_template item_template = db.item_template.Find(id);
            if (item_template == null)
            {
                return HttpNotFound();
            }
            return View(item_template);
        }

        // POST: item_template/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(decimal id)
        {
            item_template item_template = db.item_template.Find(id);
            db.item_template.Remove(item_template);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
