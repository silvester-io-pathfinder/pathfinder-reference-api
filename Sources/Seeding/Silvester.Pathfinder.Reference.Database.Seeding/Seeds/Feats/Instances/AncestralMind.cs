using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AncestralMind : Template
    {
        public static readonly Guid ID = Guid.Parse("1fff643e-3553-4885-91c1-45a228956d50");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Ancestral Mind",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8356e3aa-00c7-422e-91e2-2f537bfc34a8"), Type = TextBlockType.Text, Text = "By unraveling memories and connections passed down from your progenitors, you learn to convert your inherent magic into psychic power. You can cast any innate spells you know from an ancestry feat or heritage using your psychic spellcasting components. When you do so, the spell's tradition becomes occult, if it wasn't already, and you can use your psychic spellcasting ability modifier instead of the ability modifier you would ordinarily use for your ancestry spells, if different, to determine your spell attack roll and spell DC." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c4017b80-d2e8-4ef3-9728-9c0912d8be77"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
