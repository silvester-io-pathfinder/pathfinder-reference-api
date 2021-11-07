using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GnomeObsession : Template
    {
        public static readonly Guid ID = Guid.Parse("c9a9249b-1cb9-4f09-ae82-8a6bef1f4239");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Gnome Obsession",
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
            yield return new TextBlock { Id = Guid.Parse("de4235ae-72a9-45da-a887-568a430ea4df"), Type = TextBlockType.Text, Text = "You might have a flighty nature, but when a topic captures your attention, you dive into it headfirst. Pick a Lore skill. You gain the trained proficiency rank in that skill. At 2nd level, you gain expert proficiency in the chosen Lore as well as the Lore granted by your background, if any. At 7th level you gain master proficiency in these Lore skills, and at 15th level you gain legendary proficiency in them." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("54b0b421-d676-4985-9e4d-d122185fab1a"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
