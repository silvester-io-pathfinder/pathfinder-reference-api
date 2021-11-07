using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class StepLively : Template
    {
        public static readonly Guid ID = Guid.Parse("712107e9-2a6e-40f6-af2d-86ab6377c8db");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Step Lively",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "A Large or larger enemy ends a move action adjacent to you.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("518bd701-5777-44e1-96ed-b9d15bffdb04"), Type = TextBlockType.Text, Text = "You are an expert at avoiding the lumbering footsteps of larger creatures. You (action: Step) to another space adjacent to the enemy." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d92b1005-d617-4708-b256-36a287702a59"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
