using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class Paralyze : Template
    {
        public static readonly Guid ID = Guid.Parse("a99f55f3-63c7-4db8-8b0f-9f452a58e240");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Paralyze",
                Level = 3,
                Range = "30 feet.",
                Duration = "Varies.",
                Targets = "1 creature.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("15c15918-675a-401b-a53a-0c568fa818ab"), Type = TextBlockType.Text, Text = "You block the target's motor impulses before they can leave its mind, threatening to freeze the target in place. The target must attempt a Will save." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("d0af80a8-498a-4f0f-b659-a08eb347a5fb"), 
                Level = "7th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("8d281635-7f52-47b2-bed6-b0ed6ea0db19"), Type = TextBlockType.Text, Text = "You can target up to 10 creatures." }
                }
            };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("877d6e02-66b4-49ec-aab0-5b3e83727095"),
                CriticalSuccess = "The target is unaffected.",
                Success = "The target is stunned 1.",
                Failure = "The target is paralyzed for 1 round.",
                CriticalFailure = "The target is paralyzed for 4 rounds. At the end of each of its turns, it can attempt a new Will save to reduce the remaining duration by 1 round, or end it entirely on a critical success."
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Arcane.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Enchantment.ID;
            yield return Traits.Instances.Incapacitation.ID;
            yield return Traits.Instances.Mental.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b6a9a62e-1792-4f76-93f9-ef02c5f4b4f2"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 356
            };
        }
    }
}
