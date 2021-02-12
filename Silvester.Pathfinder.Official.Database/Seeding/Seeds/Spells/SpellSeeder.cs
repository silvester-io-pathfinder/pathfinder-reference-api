using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Official.Database.Extensions;
using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Linq;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells
{
    public class SpellSeeder
    {
        public ModelBuilder Builder { get; }

        public MagicSchool[] MagicSchools { get; }

        public MagicTradition[] MagicTraditions { get; }

        public SpellComponent[] SpellComponents { get; }

        public Trait[] Traits { get; }

        public ActionType[] ActionTypes { get; }

        public SpellType[] SpellTypes { get; }
        
        public SavingThrowStat[] SavingThrowStats { get; }

        public SpellSeeder(ModelBuilder builder, MagicSchool[] schools, MagicTradition[] traditions, SpellComponent[] spellComponents, Trait[] traits, ActionType[] actionTypes, SpellType[] spellTypes, SavingThrowStat[] savingThrowStats)
        {
            Builder = builder;
            MagicSchools = schools;
            MagicTraditions = traditions;
            SpellComponents = spellComponents;
            Traits = traits;
            ActionTypes = actionTypes;
            SpellTypes = spellTypes;
            SavingThrowStats = savingThrowStats;
        }

        public void Seed()
        {
            foreach(Type templateType in GetType().Assembly.GetTypes().Where(e => e.IsSubclassOf(typeof(AbstractSpellTemplate))))
            {
                AbstractSpellTemplate template = (AbstractSpellTemplate) Activator.CreateInstance(templateType)!;
                template.Seed(this);
            }
        }

        public MagicSchool[] FilterSchools(params string[] schoolNames)
        {
            return Filter(MagicSchools, (e) => e.Name, schoolNames);
        }

        public ActionType[] FilterActionTypes(params string[] actionTypeNames)
        {
            return Filter(ActionTypes, (e) => e.Name, actionTypeNames);
        }

        public SpellType[] FilterSpellTypes(params string[] spellTypeNames)
        {
            return Filter(SpellTypes, (e) => e.Name, spellTypeNames);
        }

        public MagicTradition[] FilterTraditions(params string[] traditionNames)
        {
            return Filter(MagicTraditions, (e) => e.Name, traditionNames);
        }

        public SpellComponent[] FilterSpellComponents(params string[] componentNames)
        {
            return Filter(SpellComponents, (e) => e.Name, componentNames);
        }

        public Trait[] FilterTraits(params string[] traitNames)
        {
            return Filter(Traits, (e) => e.Name, traitNames);
        }

        public SavingThrowStat[] FilterSavingThrowStats(params string[] savingThrowStatNames)
        {
            return Filter(SavingThrowStats, (e) => e.Name, savingThrowStatNames);
        }

        protected T[] Filter<T>(T[] options, Func<T, string> selector, params string[] names)
        {
            T[] matches = options
                .Where(option => names.Contains(selector.Invoke(option)))
                .ToArray();

            return matches.Length == names.Length
                ? matches
                : throw InvalidSelectorException<T>(matches, selector, names);
        }

        public Exception InvalidSelectorException<T>(T[] matches, Func<T, string> selector, params string[] names)
        {
            Console.WriteLine("NAMES: " + string.Join(", ", names));
            Console.WriteLine("MATCHES: " + string.Join(", ", matches.OfType<Trait>().Select(e => e.Name)));
            Console.WriteLine("MATCHES COUNT: " + matches.Length);
            Console.WriteLine("NAMES COUNT: " + names.Length);

            return new InvalidOperationException($"Not all entity names could be found: {string.Join(", ", matches.Select(selector).GetMissing(names))}.");
        }
    }
}
