using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Cynical : Template
    {
        public static readonly Guid ID = Guid.Parse("94b7136a-2078-4e83-851c-852f2aa6e541");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Cynical",
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
            yield return new TextBlock { Id = Guid.Parse("8fb70e7c-c78f-4eb8-84f7-83af1945dd70"), Type = TextBlockType.Text, Text = "You’ve been approached with suspicion and distrust throughout your life and return these sentiments back to the strangers you encounter. As a result, you are difficult to deceive. You gain a +1 circumstance bonus to your Perception DC against (action: Lies | Lie) and (action: Impersonations | Impersonate)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("820d0312-2770-4c89-b823-44bb7a040d3f"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
