using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Official.Database.Extensions;
using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;

namespace Silvester.Pathfinder.Official.Database
{

    public class OfficialDatabase : DbContext
    {
        public OfficialDatabase(DbContextOptions<OfficialDatabase> options)
            : base(options)
        {

        }

        public DbSet<Ability> Abilities { get; set; } = default!;
        public DbSet<Models.Action> Actions { get; set; } = default!;
        public DbSet<ActionType> ActionTypes { get; set; } = default!;
        public DbSet<AlchemicalBomb> AlchemicalBombs { get; set; } = default!;
        public DbSet<AlchemicalElixir> AlchemicalElixirs { get; set; } = default!;
        public DbSet<AlchemicalPoison> AlchemicalPoisons { get; set; } = default!;
        public DbSet<AlchemicalTool> AlchemicalTools { get; set; } = default!;
        public DbSet<Alignment> Alignments { get; set; } = default!;
        public DbSet<Ammunition> Ammunitions { get; set; } = default!;
        public DbSet<Armor> Armors { get; set; } = default!;
        public DbSet<Artifact> Artifacts { get; set; } = default!;
        public DbSet<ArmorPropertyRune> ArmorPropertyRunes { get; set; } = default!;
        public DbSet<ArmorCategory> ArmorGroups { get; set; } = default!;
        public DbSet<AttackType> AttackTypes { get; set; } = default!;
        public DbSet<BenefitType> BenefitTypes { get; set; } = default!;
        public DbSet<Bulk> Bulks { get; set; } = default!;
        public DbSet<Class> Classes { get; set; } = default!;
        public DbSet<ConditionCategory> ConditionCategories { get; set; } = default!;
        public DbSet<Condition> Conditions { get; set; } = default!;
        public DbSet<Curse> Curses { get; set; } = default!;
        public DbSet<DamageType> DamageTypes { get; set; } = default!;
        public DbSet<Deity> Deities { get; set; } = default!;
        public DbSet<DeityCategory> DeityCategories { get; set; } = default!;
        public DbSet<Disease> Diseases { get; set; } = default!;
        public DbSet<DivineFont> DivineFonts { get; set; } = default!;
        public DbSet<Domain> Domains { get; set; } = default!;
        public DbSet<Feat> Feats { get; set; } = default!;
        public DbSet<FeatType> FeatTypes { get; set; } = default!;
        public DbSet<SpellType> FocusTypes { get; set; } = default!;
        public DbSet<FundamentalArmorRune> FundamentalArmorRunes { get; set; } = default!;
        public DbSet<FundamentalWeaponRune> FundamentalWeaponRunes { get; set; } = default!;
        public DbSet<Frequency> Frequencies { get; set; } = default!;
        public DbSet<HazardComplexity> HazardComplexities { get; set; } = default!;
        public DbSet<Immunity> HazardImmunities { get; set; } = default!;
        public DbSet<Hazard> Hazards { get; set; } = default!;
        public DbSet<HazardType> HazardTypes { get; set; } = default!;
        public DbSet<Heritage> Heritages { get; set; } = default!;
        public DbSet<Item> Items { get; set; } = default!;
        public DbSet<ItemCategory> ItemCategories { get; set; } = default!;
        public DbSet<ItemCurse> ItemCurses { get; set; } = default!;
        public DbSet<Language> Languages { get; set; } = default!;
        public DbSet<LanguageType> LanguageTypes { get; set; } = default!;
        public DbSet<Lore> Lores { get; set; } = default!;
        public DbSet<MagicEssence> MagicEssences { get; set; } = default!;
        public DbSet<MagicSchool> MagicSchools { get; set; } = default!;
        public DbSet<MagicTradition> MagicTraditions { get; set; } = default!;
        public DbSet<Mystery> Mysteries { get; set; } = default!;
        public DbSet<PlaneCategory> PlaneCategories { get; set; } = default!;
        public DbSet<Plane> Planes { get; set; } = default!;
        public DbSet<Potency> Potencies { get; set; } = default!;
        public DbSet<PreciousMaterial> PreciousMaterials { get; set; } = default!;
        public DbSet<PreciousMaterialArmor> PreciousMaterialArmors { get; set; } = default!;
        public DbSet<PreciousMaterialItemCategory> PreciousMaterialItemCategories { get; set; } = default!;
        public DbSet<PreciousMaterialShield> PreciousMaterialShields{ get; set; } = default!;
        public DbSet<PreciousMaterialWeapon> PreciousMaterialWeapons { get; set; } = default!;
        public DbSet<Prerequisite> Prerequisites { get; set; } = default!;
        public DbSet<Proficiency> Proficiencies { get; set; } = default!;
        public DbSet<Race> Races { get; set; } = default!;
        public DbSet<RaceSize> RaceSizes { get; set; } = default!;
        public DbSet<MeleeWeapon> RangedWeapons { get; set; } = default!;
        public DbSet<Rarity> Rarities { get; set; } = default!;
        public DbSet<SavingThrowStat> SavingThrowStats { get; set; } = default!;
        public DbSet<Shield> Shields { get; set; } = default!;
        public DbSet<Skill> Skills { get; set; } = default!;
        public DbSet<Source> Sources { get; set; } = default!;
        public DbSet<SpellComponent> SpellComponents { get; set; } = default!;
        public DbSet<Spell> Spells { get; set; } = default!;
        public DbSet<SpellType> SpellTypes { get; set; } = default!;
        public DbSet<Stat> Stats { get; set; } = default!;
        public DbSet<Trait> Traits { get; set; } = default!;
        public DbSet<MeleeWeapon> MeleeWeapons { get; set; } = default!;
        public DbSet<WeaponPropertyRune> WeaponPropertyRunes { get; set; } = default!;
        public DbSet<WeaponGroup> WeaponGroups { get; set; } = default!;
        public DbSet<WeaponCategory> WeaponCategories { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //Debugger.Launch();

            ConfigureEntities(builder);
            SeedEntities(builder);
        }

        private void ConfigureEntities(ModelBuilder builder)
        {
            foreach (Type entityType in GetType().Assembly.GetTypes().Where(e => e.BaseType != null && e.BaseType == (typeof(BaseEntity)) && e.GetInterfaces().Contains(typeof(IOwnedEntity)) == false))
            {
                Console.WriteLine($"Preprocessing: '{entityType.Name}'.");

                GetType()
                    .GetMethod(nameof(ConfigureEntity), BindingFlags.NonPublic | BindingFlags.Static)!
                    .MakeGenericMethod(entityType)!
                    .Invoke(this, new object[] { builder });
            }
        }

        private void SeedEntities(ModelBuilder builder)
        {
            foreach (Type entityType in GetType().Assembly.GetTypes().Where(e => e.IsSubclassOf(typeof(BaseEntity))))
            {
                Console.WriteLine($"Seeding: '{entityType.Name}'.");

                GetType()
                    .GetMethod(nameof(SeedEntity), BindingFlags.NonPublic | BindingFlags.Static)!
                    .MakeGenericMethod(entityType)!
                    .Invoke(this, new object[] { builder });
            }
        }

        private static void ConfigureEntity<TEntity>(ModelBuilder builder)
            where TEntity : BaseEntity
        {
            new ConfiguratorProvider<TEntity>()
                .GetConfigurator()
                .Configure(builder);
        }

        private static void SeedEntity<TEntity>(ModelBuilder builder)
            where TEntity : BaseEntity
        {
            Activator
                .CreateInstance<EntitySeeder<TEntity>>()
                .Seed(builder);
        }
    }
}
