using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AncestralMind : Template
    {
        public static readonly Guid ID = Guid.Parse("1ccaf8b4-e15a-42d4-82ea-7af56dd368ab");

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
            yield return new TextBlock { Id = Guid.Parse("99ac82f9-8d48-418f-a328-284ffeca2a2a"), Type = TextBlockType.Text, Text = "By unraveling memories and connections passed down from your progenitors, you learn to convert your inherent magic into psychic power. You can cast any innate spells you know from an ancestry feat or heritage using your psychic spellcasting components. When you do so, the spell’s tradition becomes occult, if it wasn’t already, and you can use your psychic spellcasting ability modifier instead of the ability modifier you would ordinarily use for your ancestry spells, if different, to determine your spell attack roll and spell DC." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1704ec5d-d277-4cfc-a062-c650156f2150"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
