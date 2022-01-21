using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class CoralEruption : Template
    {
        public static readonly Guid ID = Guid.Parse("b6abb418-669d-45d7-9833-78b0072be7d2");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Coral Eruption",
                Level = 4,
                Range = "120 feet.",
                Duration = "1 minute.",
                Area = "Two 10-foot bursts that don't overlap.",
                IsSavingThrowBasic = true,
                SavingThrowStatId = SavingThrowStats.Instances.Reflex.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                MagicSchoolId = MagicSchools.Instances.Conjuration.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f2058c7d-ecf2-4aee-a5a7-4ff701dc0f98"), Type = TextBlockType.Text, Text = "Razor sharp coral growths erupt from the ground, transforming the landscape into a dangerous coral reef. You can create a third nonoverlapping burst if the centers of all three bursts are underwater. Creatures in the area when the spell is cast take 6d6 piercing damage and must attempt a basic Reflex save. A creature that critically fails its saving throw also takes 1d6 persistent bleed damage." };
            yield return new TextBlock { Id = Guid.Parse("c4fc5192-a93e-494f-82b4-96f7fb66faa2"), Type = TextBlockType.Text, Text = "The area becomes difficult terrain and hazardous terrain. A creature that moves through the area takes 3 piercing damage for every square of that area it moves into." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("457b399c-519b-441c-9e83-572e77f0bf7a"),
                Level = "+2",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("ddbd4a09-80c8-4b80-9e7f-c1e96b1599f6"), Type = TextBlockType.Text, Text = "The initial piercing damage increases by 3d6, and the hazardous terrain damage increases by 1." }
                }
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
            builder.Add(Guid.Parse("1223b540-77a3-400e-ac2f-8f8c34a0bf79"), Traits.Instances.Conjuration.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c45bdc36-fac1-40c2-a6c7-62d93233043c"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 96
            };
        }
    }
}
