using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Official.Database.Extensions;
using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Classes;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Feats;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Silvester.Pathfinder.Official.Database
{
    public class BaseEntity
    {
        public Guid Id { get; set; }
    }

    public class OfficialDatabase : DbContext
    {
        public OfficialDatabase(DbContextOptions<OfficialDatabase> options)
            : base(options)
        {

        }

        public DbSet<Alignment> Alignments { get; set; } = default!;

        public DbSet<ArmorGroup> ArmorGroups { get; set; } = default!;

        public DbSet<Class> Classes { get; set; } = default!;

        public DbSet<Bulk> Bulks { get; set; } = default!;

        public DbSet<Stat> Stats { get; set; } = default!;

        public DbSet<RaceRarity> RaceRarities { get; set; } = default!;

        public DbSet<RaceTrait> RaceTraits { get; set; } = default!;

        public DbSet<RaceSize> RaceSizes { get; set; } = default!;

        public DbSet<LanguageType> LanguageTypes { get; set; } = default!;

        public DbSet<Language> Languages { get; set; } = default!;

        public DbSet<Source> Sources { get; set; } = default!;

        public DbSet<Race> Races { get; set; } = default!;

        public DbSet<Skill> Skills { get; set; } = default!;

        public DbSet<Feat> Feats { get; set; } = default!;
        
        public DbSet<Spell> Spells { get; set; } = default!;

        public DbSet<ActionType> ActionTypes { get; set; } = default!;

        public DbSet<Deity> Deities { get; set; } = default!;

        public DbSet<DeityCategory> DeityCategories { get; set; } = default!;

        public DbSet<DivineFont> DivineFonts { get; set; } = default!;

        public DbSet<DeityFollowerAlignment> DeityFollowerAlignments { get; set; } = default!;

        public DbSet<Domain> Domains { get; set; } = default!;

        public DbSet<Frequency> Frequencies { get; set; } = default!;

        public DbSet<Proficiency> Proficiencies { get; set; } = default!;

        public DbSet<Prerequisite> Prerequisites { get; set; } = default!;

        public DbSet<Plane> Planes { get; set; } = default!;

        public DbSet<PlaneCategory> PlaneCategories { get; set; } = default!;

        public DbSet<PlaneTrait> PlaneTraits { get; set; } = default!;

        public DbSet<Lore> Lores { get; set; } = default!;

        public DbSet<HeritageRarity> HeritageRarities { get; set; } = default!;

        public DbSet<Heritage> Heritages { get; set; } = default!;

        public DbSet<FeatType> FeatTypes { get; set; } = default!;

        public DbSet<BenefitType> BenefitTypes { get; set; } = default!;

        public DbSet<MagicSchool> MagicSchools { get; set; } = default!;

        public DbSet<MagicTradition> MagicTraditions { get; set; } = default!;

        public DbSet<MagicEssence> MagicEssences { get; set; } = default!;

        public DbSet<SpellComponent> SpellComponents { get; set; } = default!;

        public DbSet<SavingThrowStat> SavingThrowStats { get; set; } = default!;

        public DbSet<Trait> Traits { get; set; } = default!;

        public DbSet<SpellType> SpellTypes { get; set; } = default!;

        public DbSet<ItemCategory> ItemCategories { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<SpellDetailBlock>().HasBaseEntityKey();
            modelBuilder.Entity<SpellTrigger>().HasBaseEntityKey();

            ItemCategory[] itemCategorySeed = modelBuilder.Entity<ItemCategory>().HasBaseEntityKey().HasDataSeed(new ItemCategorySeeder());
            SpellType[] spellTypeSeed = modelBuilder.Entity<SpellType>().HasBaseEntityKey().HasDataSeed(new SpellTypeSeeder());
            Trait[] traitSeed = modelBuilder.Entity<Trait>().HasBaseEntityKey().HasDataSeed(new TraitSeeder());
            SavingThrowStat[] savingThrowStatSeed = modelBuilder.Entity<SavingThrowStat>().HasBaseEntityKey().HasDataSeed(new SavingThrowStatSeeder());
            SpellComponent[] spellComponentSeed = modelBuilder.Entity<SpellComponent>().HasBaseEntityKey().HasDataSeed(new SpellComponentSeeder());
            MagicEssence[] magicEssenceSeed = modelBuilder.Entity<MagicEssence>().HasBaseEntityKey().HasDataSeed(new MagicEssenceSeeder());
            MagicSchool[] magicSchoolSeed = modelBuilder.Entity<MagicSchool>().HasBaseEntityKey().HasDataSeed(new MagicSchoolSeeder());
            MagicTradition[] magicTraditionSeed = modelBuilder.Entity<MagicTradition>().HasBaseEntityKey().HasDataSeed(new MagicTraditionSeeder());
            FeatType[] featTypeSeed = modelBuilder.Entity<FeatType>().HasBaseEntityKey().HasDataSeed(new FeatTypeSeeder());
            HeritageRarity[] heritageRaritySeed = modelBuilder.Entity<HeritageRarity>().HasBaseEntityKey().HasDataSeed(new HeritageRaritySeeder());
            BenefitType[] benefitTypeSeed = modelBuilder.Entity<BenefitType>().HasBaseEntityKey().HasDataSeed(new BenefitTypeSeeder());
            Heritage[] heritageSeed = modelBuilder.Entity<Heritage>().HasBaseEntityKey().HasDataSeed(new HeritageSeeder());
            Frequency[] frequencySeed = modelBuilder.Entity<Frequency>().HasBaseEntityKey().HasDataSeed(new FrequencySeeder());
            Domain[] domainSeed = modelBuilder.Entity<Domain>().HasBaseEntityKey().HasDataSeed(new DomainSeeder());
            Alignment[] alignmentSeed = modelBuilder.Entity<Alignment>().HasBaseEntityKey().HasDataSeed(new AlignmentSeeder());
            ActionType[] actionTypeSeed = modelBuilder.Entity<ActionType>().HasBaseEntityKey().HasDataSeed(new ActionTypeSeeder());
            Source[] sourceSeed = modelBuilder.Entity<Source>().HasBaseEntityKey().HasDataSeed(new SourceSeeder());
            ArmorGroup[] armourGroupSeed = modelBuilder.Entity<ArmorGroup>().HasBaseEntityKey().HasDataSeed(new ArmorGroupSeeder());
            Proficiency[] proficiencySeed = modelBuilder.Entity<Proficiency>().HasBaseEntityKey().HasDataSeed(new ProficiencySeeder());
            Bulk[] bulkSeed = modelBuilder.Entity<Bulk>().HasBaseEntityKey().HasDataSeed(new BulkSeeder());
            Stat[] statSeed = modelBuilder.Entity<Stat>().HasBaseEntityKey().HasDataSeed(new StatSeeder());
            Skill[] skillSeed = modelBuilder.Entity<Skill>().HasBaseEntityKey().HasDataSeed(new SkillSeeder());
            DeityCategory[] deityCategoriesSeed = modelBuilder.Entity<DeityCategory>().HasBaseEntityKey().HasDataSeed(new DeityCategorySeeder());
            Deity[] deitySeed = modelBuilder.Entity<Deity>().HasBaseEntityKey().HasDataSeed(new DeitySeeder());
            RaceRarity[] raceRaritySeed = modelBuilder.Entity<RaceRarity>().HasBaseEntityKey().HasDataSeed(new RaceRaritySeeder());
            DivineFont[] divineFontSeed = modelBuilder.Entity<DivineFont>().HasBaseEntityKey().HasDataSeed(new DivineFontSeeder());
            RaceTrait[] raceTraitSeed = modelBuilder.Entity<RaceTrait>().HasBaseEntityKey().HasDataSeed(new RaceTraitSeeder());
            RaceSize[] raceSizeSeed = modelBuilder.Entity<RaceSize>().HasBaseEntityKey().HasDataSeed(new RaceSizeSeeder());
            LanguageType[] languageTypeSeed = modelBuilder.Entity<LanguageType>().HasBaseEntityKey().HasDataSeed(new LanguageTypeSeeder());
            Language[] languageSeed = modelBuilder.Entity<Language>().HasBaseEntityKey().HasDataSeed(new LanguageSeeder());
            Race[] raceSeed = modelBuilder.Entity<Race>().HasBaseEntityKey().HasDataSeed(new RaceSeeder());
            PlaneCategory[] planeCategoriesSeed = modelBuilder.Entity<PlaneCategory>().HasBaseEntityKey().HasDataSeed(new PlaneCategorySeeder());
            PlaneTrait[] planeTraitSeed = modelBuilder.Entity<PlaneTrait>().HasBaseEntityKey().HasDataSeed(new PlaneTraitSeeder());
            Plane[] planeSeed = modelBuilder.Entity<Plane>().HasBaseEntityKey().HasDataSeed(new PlaneSeeder());

            //Feat effects
            modelBuilder.Entity<FeatEffect>().HasBaseEntityKey();
            modelBuilder.Entity<OrFeatEffect>();
            modelBuilder.Entity<GainHeritageEffect>();
            modelBuilder.Entity<GainLoreEffect>();
            modelBuilder.Entity<GainHeritageFeatEffect>();

            //Prerequisites
            modelBuilder.Entity<Prerequisite>().HasBaseEntityKey();
            modelBuilder.Entity<SkillPrerequisite>();
            modelBuilder.Entity<LevelPrerequisite>();
            modelBuilder.Entity<FeatPrerequisite>();
            modelBuilder.Entity<DeityPrerequisite>();
            modelBuilder.Entity<StatPrerequisite>();
            modelBuilder.Entity<LorePrerequisite>();
            modelBuilder.Entity<OrPrerequisite>();

            //Lores
            Lore[] loreSeed = modelBuilder.Entity<Lore>().HasBaseEntityKey().HasDataSeed(new LoreSeeder());
            modelBuilder.Entity<DeityLore>().HasDataSeed(new DeityLoreSeeder());
            modelBuilder.Entity<ConsumableLore>().HasDataSeed(new ConsumableLoreSeeder());
            modelBuilder.Entity<SettlementLore>().HasDataSeed(new SettlementLoreSeeder());
            modelBuilder.Entity<PlaneLore>().HasDataSeed(new PlaneLoreSeeder());
            modelBuilder.Entity<CreatureLore>().HasDataSeed(new CreatureLoreSeeder());
            modelBuilder.Entity<TerrainLore>().HasDataSeed(new TerrainLoreSeeder());

            //Many to many joins
            modelBuilder.Join(planeSeed, planeTraitSeed, new PlaneTraitJoiner());
            modelBuilder.Join(raceSeed, languageSeed, new RaceLanguageJoiner());
            modelBuilder.Join(raceSeed, raceTraitSeed, new RaceTraitJoiner());
            modelBuilder.Join(deitySeed, domainSeed, new DeityDomainJoiner());
            modelBuilder.Join(deitySeed, divineFontSeed, new DeityDivineFontJoiner());
            modelBuilder.Join(deitySeed, alignmentSeed, new DeityFollowerAlignmentJoiner());
            modelBuilder.Join(heritageSeed, raceSeed, new HeritageRaceJoiner());

            //More complex seeds for Feats and Spells.
            new FeatSeeder(modelBuilder, traitSeed, actionTypeSeed, featTypeSeed, proficiencySeed, loreSeed, heritageRaritySeed, itemCategorySeed, skillSeed, statSeed).Seed();
            new SpellSeeder(modelBuilder, magicSchoolSeed, magicTraditionSeed, spellComponentSeed, traitSeed, actionTypeSeed, spellTypeSeed, savingThrowStatSeed).Seed();
            new ClassSeeder(modelBuilder, traitSeed, actionTypeSeed, featTypeSeed, proficiencySeed, loreSeed, heritageRaritySeed, itemCategorySeed, skillSeed, statSeed, magicTraditionSeed);
        }
    }
}
