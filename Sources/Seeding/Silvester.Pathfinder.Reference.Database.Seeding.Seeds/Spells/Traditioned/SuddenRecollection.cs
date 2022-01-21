using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class SuddenRecollection : Template
    {
        public static readonly Guid ID = Guid.Parse("392d6912-2cec-45c2-aec0-f58f08ab473a");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Sudden Recollection",
                Level = 3,
                Range = "30 feet.",
                Duration = "Unlimited.",
                Targets = "1 creature.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9c0c69c5-64ca-4a2f-8dec-8a8e6946e6bc"), Type = TextBlockType.Text, Text = "You place a bit of knowledge deep in a creature�s subconscious or make a willing creature forget some information until a specific trigger occurs. The target gets a Will saving throw to resist the effect. A willing creature can choose to fail its save." };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("6e135257-bdb1-40a5-989c-05c8a7dff181"),
                CriticalSuccess = "The target is unaffected and realizes you tried to alter its memory.",
                Success = "The target is unaffected but thinks your spell was something harmless instead of sudden recollection, unless it identifies the spell.",
                Failure = "You choose a piece of information the target didn�t already know and create a trigger, such as seeing an object, hearing a key phrase, or witnessing an event. As soon as the target experiences the trigger, it receives the information and the spell ends. If the target was willing, you can instead choose a piece of information the target already knew and suppress its memory of that information until it experiences the trigger, after which it recovers the information and the spell ends.",
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("a9442bac-56dd-4208-892f-7256e9912cce"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("010dd0ba-e01f-48b5-bad1-3890f36c6d44"), Traits.Instances.Enchantment.ID);
            builder.Add(Guid.Parse("23fb8961-55e3-4a41-b585-eb734e25ca62"), Traits.Instances.Mental.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cf6ccb3d-7251-4289-94e7-82c4c3ada8ec"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 130
            };
        }
    }
}
