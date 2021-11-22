using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class Schadenfreude : Template
    {
        public static readonly Guid ID = Guid.Parse("7d527670-483b-4c1a-9994-c4474a7bf13f");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Schadenfreude",
                Level = 1,
                Range = "30 feet.",
                Trigger = "You critically fail a saving throw against a foe�s effect.",
                Targets = "The triggering foe.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f172b602-5029-4a66-8ac6-7183ab566118"), Type = TextBlockType.Text, Text = "You distract your enemy with their feeling of smug pleasure when you fail catastrophically. They must attempt a Will save." };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("d54d6dd2-5e62-43ea-bb56-171974074446"),
                CriticalSuccess = "The creature is unaffected.",
                Success = "The creature is distracted by its amusement and takes a �1 status penalty on Perception checks and Will saves for 1 round.",
                Failure = "The creature is overcome by its amusement and is stupefied 1 for 1 round.",
                CriticalFailure = "The creature is lost in its amusement and is stupefied 2 for 1 round and stunned 1."
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Arcane.ID;
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Emotion.ID;
            yield return Traits.Instances.Enchantment.ID;
            yield return Traits.Instances.Mental.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6cd1d817-d46c-433e-af13-3a416187e7fa"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 127
            };
        }
    }
}
