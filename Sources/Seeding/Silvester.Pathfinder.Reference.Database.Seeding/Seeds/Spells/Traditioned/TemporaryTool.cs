using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class TemporaryTool : Template
    {
        public static readonly Guid ID = Guid.Parse("c4d0346b-b1a4-4de2-b840-98756cbc6869");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Temporary Tool",
                Level = 1,
                CastTime = "1 minute.",
                Duration = "Until used or 1 minute.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                MagicSchoolId = MagicSchools.Instances.Conjuration.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d77e2d62-440d-432f-81a3-63f1b3782253"), Type = TextBlockType.Text, Text = "You conjure a temporary simple tool, such as a shovel or rope into your hands. It lasts until it is used for a single activity or for 1 minute, whichever comes first, after which it disappears. The tool is obviously temporarily conjured, and thus can�t be sold or passed off as a genuine item." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield break;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Arcane.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Conjuration.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2f417f62-3796-4e0d-ba36-aa0cdbc567e6"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 110
            };
        }
    }
}
