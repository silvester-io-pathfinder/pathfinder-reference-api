using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class Entangle : Template
    {
        public static readonly Guid ID = Guid.Parse("1472aa71-14ec-4a01-a4ec-f82cbebdb1ed");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Entangle",
                Level = 2,
                Range = "120 feet.",
                Area = "All squares in a 20-foot-radius burst that contain plants.",
                Duration = "1 minute.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Transmutation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b72ecf42-66d3-4d4e-a854-9f26a2ecafdc"), Type = TextBlockType.Text, Text = "Plants in the area entangle creatures. The area counts as difficult terrain. Each round that a creature starts its turn in the area, it must attempt a Reflex save. On a failure, it takes a –10-foot circumstance penalty to its Speeds until it leaves the area, and on a critical failure, it is also immobilized for 1 round. Creatures can attempt to Escape at entangle's DC to remove these effects." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("a38f5d55-1f04-4156-b854-8e5d4a4a4d83"), Traits.Instances.Plant.ID);
            builder.Add(Guid.Parse("2e813f00-bdb8-4d09-85be-f3b34042eb37"), Traits.Instances.Transmutation.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("43c13a73-d16f-45ab-891b-1b75ec8e9619"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 336
            };
        }
    }
}
