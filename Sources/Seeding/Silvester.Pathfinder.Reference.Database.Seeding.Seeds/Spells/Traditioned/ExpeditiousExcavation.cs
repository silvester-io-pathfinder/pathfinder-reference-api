using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class ExpeditiousExcavation : Template
    {
        public static readonly Guid ID = Guid.Parse("2c810c8d-b476-40db-bba3-7eb52af274c1");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Expeditious Excavation",
                Level = 2,
                Range = "Touch.",
                Area = "Cube of dirt 5 feet across or smaller.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Reflex.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Transmutation.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("468cf077-5895-4e2f-9a41-6bd74847ceef"), Type = TextBlockType.Text, Text = "You remove loose dirt, dust, gravel, sand, and the like (though not solid stone) up to the size of a 5-foot cube. Any Medium or smaller creature standing atop the earth when the spell is cast must attempt a Reflex save or Acrobatics check." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("afb5e08d-1d62-4ce7-a2b9-4aebd5f43e2f"),
                Level = "+2",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("4af442c8-4831-4003-aa6e-74551b1c709d"), Type = TextBlockType.Text, Text = "The spell can excavate an additional 5-foot cube of earth. If you excavate all four 5-foot cubes beneath a Large creature, it must attempt a Reflex save or Acrobatics check, as above." }
                }
            };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("411e340e-2d6f-4ce1-b06d-cea872ba4cfc"),
                Success = "The creature is unaffected and can choose to either descend the pit without damage or move to the nearest available space of its choice.",
                Failure = "The creature falls prone in the nearest available space of its choice, or falls into the pit if it prefers.",
                CriticalFailure = "The creature falls into the pit excavated by the spell and lands prone, taking falling damage as normal."
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
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("59746697-8f7d-4e69-9b5c-4cfae4574f69"), Traits.Instances.Earth.ID);
            builder.Add(Guid.Parse("75d5da4d-4630-4c63-b9c8-29fc06cd361e"), Traits.Instances.Transmutation.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("51308989-ce83-4343-a595-e3dd98592058"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 107
            };
        }
    }
}
