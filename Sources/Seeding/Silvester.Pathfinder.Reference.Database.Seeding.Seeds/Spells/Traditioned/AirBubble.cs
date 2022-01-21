using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class AirBubble : Template
    {
        public static readonly Guid ID = Guid.Parse("fbb8d7cc-6793-484c-80a8-4fafb137e01e");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Air Bubble",
                Targets = "The triggering creature.",
                Duration = "1 minute.",
                Range = "60 feet.",
                Level = 4,
                Trigger = "A creature within range enters an environment where it can't breathe.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                MagicSchoolId = MagicSchools.Instances.Conjuration.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("eba305d2-2565-417f-8bf4-41ec967add47"), Type = Utilities.Text.TextBlockType.Text, Text = "A bubble of pure air appears around the target's head, allowing it to breathe normally.The effect ends as soon as the target returns to an environment where it can breathe normally." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Arcane.ID;
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("d8c22dc8-0e57-4429-be13-cc2d451d3f1d"), Traits.Instances.Air.ID);
            builder.Add(Guid.Parse("17cb837c-4a5e-42cf-be73-89f2a1e8a9b2"), Traits.Instances.Conjuration.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c50a048c-bf3d-4705-8697-e96431da57a7"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 316
            };
        }
    }
}
