using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Items;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;

namespace Silvester.Pathfinder.Reference.Database
{
    public class ReferenceDatabase : DbContext
    {
        public ReferenceDatabase(DbContextOptions<ReferenceDatabase> options)
            : base(options)
        {

        }

        public DbSet<Ability> Abilities { get; set; } = default!;
        public DbSet<Models.Entities.Activity> Activities { get; set; } = default!;
        public DbSet<Models.Entities.Action> Actions { get; set; } = default!;
        public DbSet<ActionType> ActionTypes { get; set; } = default!;
        public DbSet<AdventuringGear> AdventuringGears { get; set; } = default!;
        public DbSet<AlchemicalBomb> AlchemicalBombs { get; set; } = default!;
        public DbSet<AlchemicalElixir> AlchemicalElixirs { get; set; } = default!;
        public DbSet<AlchemicalPoison> AlchemicalPoisons { get; set; } = default!;
        public DbSet<AlchemicalTool> AlchemicalTools { get; set; } = default!;
        public DbSet<Alignment> Alignments { get; set; } = default!;
        public DbSet<Ammunition> Ammunitions { get; set; } = default!;
        public DbSet<Armor> Armors { get; set; } = default!;
        public DbSet<Ancestry> Ancestries { get; set; } = default!;
        public DbSet<Archetype> Archetypes { get; set; } = default!;
        public DbSet<Artifact> Artifacts { get; set; } = default!;
        public DbSet<ArmorPropertyRune> ArmorPropertyRunes { get; set; } = default!;
        public DbSet<WeaponPropertyRune> WeaponPropertyRunes { get; set; } = default!;
        public DbSet<FundamentalArmorRune> FundamentalArmorRunes { get; set; } = default!;
        public DbSet<FundamentalWeaponRune> FundamentalWeaponRunes { get; set; } = default!;
        public DbSet<ArmorCategory> ArmorCategories { get; set; } = default!;
        public DbSet<ArmorGroup> ArmorGroups { get; set; } = default!;
        public DbSet<AttackType> AttackTypes { get; set; } = default!;
        public DbSet<Background> Backgrounds { get; set; } = default!;
        public DbSet<BeastGun> BeastGuns { get; set; } = default!;
        public DbSet<BenefitType> BenefitTypes { get; set; } = default!;
        public DbSet<Bulk> Bulks { get; set; } = default!;
        public DbSet<Bloodline> Bloodlines { get; set; } = default!;
        public DbSet<Cause> Causes { get; set; } = default!;
        public DbSet<Class> Classes { get; set; } = default!;
        public DbSet<ClassFeature> ClassFeatures { get; set; } = default!;
        public DbSet<CombinationWeapon> CombinationWeapons { get; set; } = default!;
        public DbSet<ConditionCategory> ConditionCategories { get; set; } = default!;
        public DbSet<Condition> Conditions { get; set; } = default!;
        public DbSet<Curse> Curses { get; set; } = default!;
        public DbSet<DamageType> DamageTypes { get; set; } = default!;
        public DbSet<Deity> Deities { get; set; } = default!;
        public DbSet<DeityCategory> DeityCategories { get; set; } = default!;
        public DbSet<Disease> Diseases { get; set; } = default!;
        public DbSet<DivineAlly> DivineAllies { get; set; } = default!;
        public DbSet<DivineFont> DivineFonts { get; set; } = default!;
        public DbSet<DraconicExemplar> DraconicExemplars { get; set; } = default!;
        public DbSet<Doctrine> Doctrines { get; set; } = default!;
        public DbSet<Domain> Domains { get; set; } = default!;
        public DbSet<DruidicOrder> DruidicOrders { get; set; } = default!;
        public DbSet<Eidolon> Eidolons { get; set; } = default!;
        public DbSet<FamiliarAbility> FamiliarAbilities { get; set; } = default!;
        public DbSet<Feat> Feats { get; set; } = default!;
        public DbSet<GunslingersWay> GunslingersWays { get; set; } = default!;
        public DbSet<HarrowCard> HarrowCards { get; set; } = default!;
        public DbSet<HarrowCategory> HarrowCategories { get; set; } = default!;
        public DbSet<HarrowMode> HarrowModes { get; set; } = default!;
        public DbSet<HazardComplexity> HazardComplexities { get; set; } = default!;
        public DbSet<Immunity> HazardImmunities { get; set; } = default!;
        public DbSet<Hazard> Hazards { get; set; } = default!;
        public DbSet<HazardType> HazardTypes { get; set; } = default!;
        public DbSet<Heritage> Heritages { get; set; } = default!;
        public DbSet<HuntersEdge> HuntersEdges { get; set; } = default!;
        public DbSet<HybridStudy> HybridStudies { get; set; } = default!;
        public DbSet<Instinct> Instincts { get; set; } = default!;
        public DbSet<Innovation> Innovations { get; set; } = default!;
        public DbSet<InnovationModification> InnovationModifications { get; set; } = default!;
        public DbSet<InnovationModificationType> InnovationModificationTypes { get; set; } = default!;
        public DbSet<InstinctAbility> InstinctAbilities { get; set; } = default!;
        public DbSet<ItemCategory> ItemCategories { get; set; } = default!;
        public DbSet<ItemCurse> ItemCurses { get; set; } = default!;
        public DbSet<Language> Languages { get; set; } = default!;
        public DbSet<LanguageType> LanguageTypes { get; set; } = default!;
        public DbSet<Lore> Lores { get; set; } = default!;
        public DbSet<LoreCategory> LoreCategories { get; set; } = default!;
        public DbSet<MasterAbility> MasterAbilities { get; set; } = default!;
        public DbSet<MagicEssence> MagicEssences { get; set; } = default!;
        public DbSet<MagicSchool> MagicSchools { get; set; } = default!;
        public DbSet<MagicTradition> MagicTraditions { get; set; } = default!;
        public DbSet<Methodology> Methodologies { get; set; } = default!;
        public DbSet<Muse> Muses { get; set; } = default!;
        public DbSet<Mystery> Mysteries { get; set; } = default!;
        public DbSet<PatronTheme> PatronThemes { get; set; } = default!;
        public DbSet<PlaneCategory> PlaneCategories { get; set; } = default!;
        public DbSet<Plane> Planes { get; set; } = default!;
        public DbSet<Philosophy> Philosophies { get; set; } = default!;
        public DbSet<PlayMode> PlayModes { get; set; } = default!;
        public DbSet<Potency> Potencies { get; set; } = default!;
        public DbSet<PreciousMaterial> PreciousMaterials { get; set; } = default!;
        public DbSet<PreciousMaterialArmor> PreciousMaterialArmors { get; set; } = default!;
        public DbSet<PreciousMaterialObjectCategory> PreciousMaterialItemCategories { get; set; } = default!;
        public DbSet<PreciousMaterialShield> PreciousMaterialShields { get; set; } = default!;
        public DbSet<PreciousMaterialWeapon> PreciousMaterialWeapons { get; set; } = default!;
        public DbSet<Proficiency> Proficiencies { get; set; } = default!;
        public DbSet<AncestrySize> AncestrySizes { get; set; } = default!;
        public DbSet<RangedWeapon> RangedWeapons { get; set; } = default!;
        public DbSet<Racket> Rackets { get; set; } = default!;
        public DbSet<Rarity> Rarities { get; set; } = default!;
        public DbSet<ResearchField> ResearchFields { get; set; } = default!;
        public DbSet<Rule> Rules { get; set; } = default!;
        public DbSet<RuneMagic> RuneMagics { get; set; } = default!;
        public DbSet<SavingThrowStat> SavingThrowStats { get; set; } = default!;
        public DbSet<Shield> Shields { get; set; } = default!;
        public DbSet<Skill> Skills { get; set; } = default!;
        public DbSet<SkillAction> SkillActions { get; set; } = default!;
        public DbSet<Sense> Senses { get; set; } = default!;
        public DbSet<Source> Sources { get; set; } = default!;
        public DbSet<SpellComponent> SpellComponents { get; set; } = default!;
        public DbSet<Spell> Spells { get; set; } = default!;
        public DbSet<SpellType> SpellTypes { get; set; } = default!;
        public DbSet<Stat> Stats { get; set; } = default!;
        public DbSet<Stave> Staves { get; set; } = default!;
        public DbSet<Tenet> Tenets { get; set; } = default!;
        public DbSet<Trait> Traits { get; set; } = default!;
        public DbSet<UnarmedWeapon> UnarmedWeapons { get; set; } = default!;
        public DbSet<WornItem> WornItems { get; set; } = default!;
        public DbSet<HeldItem> HeldItems { get; set; } = default!;
        public DbSet<BaseItem> Items { get; set; } = default!;
        public DbSet<MeleeWeapon> MeleeWeapons { get; set; } = default!;
        public DbSet<WeaponGroup> WeaponGroups { get; set; } = default!;
        public DbSet<WeaponCategory> WeaponCategories { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            ConfigureEntities(builder);
        }

        private void ConfigureEntities(ModelBuilder builder)
        {
            foreach (Type entityType in GetApplicableConcreteTypesToConfigure())
            {
                Configure(builder, entityType);
            }
        }

        private IEnumerable<Type> GetApplicableConcreteTypesToConfigure()
        {
            return GetType()
                .Assembly
                .GetTypes()
                .Where(e => e.IsAssignableTo(typeof(BaseEntity)))
                .Where(e => e != typeof(BaseEntity))
                .Where(e => e.IsGenericType == false);
        }

        private void Configure(ModelBuilder builder, Type entityType)
        {
            Console.WriteLine($"Preprocessing: '{entityType.Name}'.");

            GetType()
                .GetMethod(nameof(Configure), BindingFlags.NonPublic | BindingFlags.Static)!
                .MakeGenericMethod(entityType)!
                .Invoke(this, new object[] { builder });
        }

        private static void Configure<TEntity>(ModelBuilder builder)
            where TEntity : BaseEntity
        {
            EntityConfiguratorProvider<TEntity> provider = new EntityConfiguratorProvider<TEntity>();
            provider.GetDefaultConfigurator().Configure(builder);
            provider.GetCustomConfigurator()?.Configure(builder);
        }
    }
}
