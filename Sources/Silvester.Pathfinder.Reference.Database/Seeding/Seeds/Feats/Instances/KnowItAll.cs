using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class KnowItAll : Template
    {
        public static readonly Guid ID = Guid.Parse("ec6f0a2b-4830-45af-963d-9cf4e30caa76");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Know-It-All",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("48aab63f-744c-4669-8c39-45ff30be7aa0"), Type = TextBlockType.Text, Text = "When you’ve heard of something at all, you’ve heard about it at length. When you succeed at a Knowledge check, you gain additional information or context. When you critically succeed at a Knowledge check, at the GM’s discretion, you might gain even more additional information or context than normal." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c7be9343-2272-42d5-9abf-a88d4ab0056a"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
