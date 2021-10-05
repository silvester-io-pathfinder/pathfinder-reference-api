using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
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

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Abjuration.ID;
            yield return Traits.Instances.Ranger.ID;
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
