using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class Stabilize : Template
    {
        public static readonly Guid ID = Guid.Parse("547992e6-0651-48b5-b1bc-3ffdf18a996f");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Stabilize",
                Level = 1,
                Range = "30 feet.",
                Targets = "1 dying creature.",
                SpellTypeId = SpellTypes.Instances.Cantrip.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("67ce3858-4860-4366-8ba7-9140cb36e280"), Type = TextBlockType.Text, Text = "Positive energy shuts death's door. The target loses the dying condition, though it remains unconscious at 0 Hit Points." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("c05b2c8a-0917-4e49-af67-3813430d440f"), Traits.Instances.Cantrip.ID);
            builder.Add(Guid.Parse("c7ae06c9-f819-49b6-a64c-c96c42614fe8"), Traits.Instances.Healing.ID);
            builder.Add(Guid.Parse("d5c0ec92-e655-4e1a-a2e3-5cafba5a2645"), Traits.Instances.Necromancy.ID);
            builder.Add(Guid.Parse("220d5b6b-8def-4c00-82c2-57a158993433"), Traits.Instances.Positive.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5ba52f8a-6933-48b7-89b5-724096900d4d"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 373
            };
        }
    }
}
