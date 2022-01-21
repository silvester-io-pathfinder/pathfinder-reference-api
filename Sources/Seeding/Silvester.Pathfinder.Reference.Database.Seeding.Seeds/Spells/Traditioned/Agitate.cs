using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class Agitate : Template
    {
        public static readonly Guid ID = Guid.Parse("50c8f473-1e04-48d8-a8c9-5da43b936346");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Agitate",
                Level = 1,
                Range = "30 feet.",
                Targets = "1 creature.",
                Duration = "Varies.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("04fe028b-5fd9-4e40-a855-3d62adfeeda3"), Type = TextBlockType.Text, Text = "You send the target's mind and body into overdrive, forcing it to become restless and hyperactive. During the duration, the target must Stride, Fly, or Swim at least once each turn or take 2d8 mental damage that turn; The GM might decide to add additional move actions to the list for creatures who possess only a more unusual form of movement. The duration of this effect depends on the target's Will save." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("c506ab3e-d898-4187-a789-5bdb28bec4e5"),
                Level = "+1",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("d7e2515c-3ae6-4159-bf88-4ef1ac153b12"), Type = TextBlockType.Text, Text = "The damage increases by 2d8." }
                }
            };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("e9986e20-ef45-4fe5-b615-69d9557fd718"),
                CriticalSuccess = "The spell has no effect.",
                Success = "The duration is 1 round.",
                Failure = "The duration is 2 rounds.",
                CriticalFailure = "The duration is 4 rounds."
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

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("7c22758b-ab04-45e0-9455-777994b188dc"), Traits.Instances.Enchantment.ID);
            builder.Add(Guid.Parse("ee58db80-1838-4c85-8af7-fe5d2b2ee211"), Traits.Instances.Mental.ID);
            builder.Add(Guid.Parse("7b01fa5f-e12c-4f4e-b801-c8d8af044629"), Traits.Instances.Nonlethal.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b4ef13f6-c93b-4296-b4c8-a88483e661cd"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 106
            };
        }
    }
}
