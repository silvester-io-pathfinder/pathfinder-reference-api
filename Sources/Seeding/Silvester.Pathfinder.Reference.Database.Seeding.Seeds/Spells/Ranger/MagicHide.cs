using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class MagicHide : Template
    {
        public static readonly Guid ID = Guid.Parse("baa6d8fe-d863-41f1-8087-9d9725bb4a81");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Magic Hide",
                Level = 1,
                Range = "30 feet.",
                Targets = "Your animal companion.",
                Duration = "1 minute.",
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                ClassId = Classes.Instances.Ranger.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Abjuration.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1c8298db-ca49-4a61-b2fa-0e3896de1f1c"), Type = TextBlockType.Text, Text = "Your animal companion grows a thicker hide, matted fur, or a harder shell, granting it a +1 status bonus to AC." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("756b3ec0-24c5-4768-8b3a-fe8e2d77c510"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("c37c631a-331d-46b3-a35f-66aedcfad404"), Traits.Instances.Abjuration.ID);
            builder.Add(Guid.Parse("89aaaf63-1c3c-4ee3-967d-d728acdc894f"), Traits.Instances.Ranger.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b14d678a-adf3-453f-9e35-17364a0848cf"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 235
            };
        }
    }
}
