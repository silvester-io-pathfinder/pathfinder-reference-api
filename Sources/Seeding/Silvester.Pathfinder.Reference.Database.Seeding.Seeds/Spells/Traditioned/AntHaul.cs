using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class AntHaul : Template
    {
        public static readonly Guid ID = Guid.Parse("001dcfdb-d978-498b-a101-1d13c57b67f2");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Ant Haul",
                Level = 1,
                Range = "Touch.",
                Duration = "8 hours.",
                Targets = "1 creature.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Transmutation.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("82850481-04c2-4bbd-9b05-13956acaa0f0"), Type = Utilities.Text.TextBlockType.Text, Text = "You reinforce the target's musculoskeletal system to bear more weight. The target can carry 3 more Bulk than normal before becoming encumbered and up to a maximum of 6 more Bulk." };
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
            builder.Add(Guid.Parse("942f0ec4-2d68-4632-b8ca-d6426814501f"), Traits.Instances.Transmutation.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("aadc1e7e-8702-4c94-a438-6a9a740e4bc9"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 318
            };
        }
    }
}
