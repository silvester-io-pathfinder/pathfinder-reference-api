using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Official.Database.Extensions;
using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Feats;
using System;
using System.Linq;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Classes
{
    public class ClassSeeder
    {
        public ModelBuilder Builder { get; }

        public Trait[] Traits { get; }

        public ActionType[] ActionTypes { get; }

        public FeatType[] FeatTypes { get; }

        public Proficiency[] Proficiencies { get; }

        public Lore[] Lores { get; }

        public HeritageRarity[] HeritageRarities { get; }

        public ItemCategory[] ItemCategories { get; }

        public Skill[] Skills { get; set; }

        public Stat[] Stats { get; set; }

        public MagicTradition[] MagicTraditions { get; set; }

        public ClassSeeder(ModelBuilder builder, Trait[] traits, ActionType[] actionTypes, FeatType[] featTypes, Proficiency[] proficiencies, Lore[] lores, HeritageRarity[] heritageRarities, ItemCategory[] itemCategories, Skill[] skills, Stat[] stats, MagicTradition[] magicTraditions)
        {
            Builder = builder;
            Traits = traits;
            ActionTypes = actionTypes;
            FeatTypes = featTypes;
            Proficiencies = proficiencies;
            Lores = lores;
            HeritageRarities = heritageRarities;
            ItemCategories = itemCategories;
            Skills = skills;
            Stats = stats;
            MagicTraditions = magicTraditions;
        }

        public void Seed()
        {
            foreach (Type templateType in GetType().Assembly.GetTypes().Where(e => e.IsSubclassOf(typeof(AbstractClassTemplate))))
            {
                AbstractClassTemplate template = (AbstractClassTemplate)Activator.CreateInstance(templateType)!;
                template.Seed(this);
            }
        }

        public ActionType[] FilterActionTypes(params string[] actionTypeNames)
        {
            return Filter(ActionTypes, (e) => e.Name, actionTypeNames);
        }

        public FeatType[] FilterFeatTypes(params string[] featTypeNames)
        {
            return Filter(FeatTypes, (e) => e.Name, featTypeNames);
        }

        public Trait[] FilterTraits(params string[] traitNames)
        {
            return Filter(Traits, (e) => e.Name, traitNames);
        }

        public Proficiency[] FilterProficiencies(params string[] proficiencyNames)
        {
            return Filter(Proficiencies, (e) => e.Name, proficiencyNames);
        }

        public Lore[] FilterLores(params string[] loreNames)
        {
            return Filter(Lores, (e) => e.Name, loreNames);
        }

        public HeritageRarity[] FilterHeritageRarities(params string[] heritageRarityNames)
        {
            return Filter(HeritageRarities, (e) => e.Name, heritageRarityNames);
        }

        public Skill[] FilterSkills(params string[] skillNames)
        {
            return Filter(Skills, (e) => e.Name, skillNames);
        }

        public Stat[] FilterStats(params string[] statNames)
        {
            return Filter(Stats, (e) => e.Name, statNames);
        }

        public MagicTradition[] FilterMagicTraditions(params string[] magicTraditionNames)
        {
            return Filter(MagicTraditions, (e) => e.Name, magicTraditionNames);
        }

        public Guid GetMagicTradition(string name)
        {
            return FilterMagicTraditions(name)[0].Id;
        }

        public Guid GetProficiency(string name)
        {
            return FilterProficiencies(name)[0].Id;
        }

        public Guid GetStat(string name)
        {
            return FilterStats(name)[0].Id;
        }

        public Guid GetSkill(string name)
        {
            return FilterSkills(name)[0].Id;
        }

        public Guid GetLore(string name)
        {
            return FilterLores(name)[0].Id;
        }

        public Guid GetHeritageRarity(string name)
        {
            return FilterHeritageRarities(name)[0].Id;
        }

        protected T[] Filter<T>(T[] options, Func<T, string> selector, params string[] names)
        {
            T[] matches = options
                .Where(option => names.Contains(selector.Invoke(option)))
                .ToArray();

            return matches.Length == names.Length
                ? matches
                : throw InvalidSelectorException(matches, selector, names);
        }

        public Exception InvalidSelectorException<T>(T[] matches, Func<T, string> selector, params string[] names)
        {
            Console.WriteLine("NAMES: " + string.Join(", ", names));
            Console.WriteLine("MATCHES: " + string.Join(", ", matches.Select(selector)));

            return new InvalidOperationException($"Not all entity names could be found: {string.Join(", ", matches.Select(selector).GetMissing(names))}.");
        }
    }
}
