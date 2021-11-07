using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Diehard : Template
    {
        public static readonly Guid ID = Guid.Parse("fdaa2cdb-fe14-443e-9cc0-ba1b77030c12");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Diehard",
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
            yield return new TextBlock { Id = Guid.Parse("bf92c532-c9e5-4426-890c-be315cd235c4"), Type = TextBlockType.Text, Text = "It takes more to kill you than most. You die from the dying condition at dying 5, rather than dying 4." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6b501f8e-08d0-4b23-9d66-ed7f8db72a4b"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
