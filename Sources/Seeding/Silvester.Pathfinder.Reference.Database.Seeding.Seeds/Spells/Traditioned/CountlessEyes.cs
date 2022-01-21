using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class CountlessEyes : Template
    {
        public static readonly Guid ID = Guid.Parse("a31c7d26-6f99-4242-908f-a667d0ca0524");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Countless Eyes",
                Level = 4,
                Range = "Touch.",
                Duration = "1 minute.",
                Targets = "1 creature.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Divination.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("fa2e65b7-f7aa-44c8-8b79-a411a1d8f2a0"), Type = TextBlockType.Text, Text = "Eyes form across the touched creature's body, allowing it to see in all directions at once. The subject can't be flanked for the spell's duration. In addition, when the subject Seeks, it can Seek in a 30-foot burst centered on itself or up to four 15-foot bursts within line of sight." };
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
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("847f6923-d123-4fb0-af31-4ef45eef1dcf"), Traits.Instances.Divination.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("566047a4-81c3-4f61-9dbd-13c3dc40ab57"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 217
            };
        }
    }
}
