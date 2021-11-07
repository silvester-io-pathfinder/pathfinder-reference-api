using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MonkMoves : Template
    {
        public static readonly Guid ID = Guid.Parse("d0f43a75-8050-4eb0-888f-21cd08a63f0a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Monk Moves",
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
            yield return new TextBlock { Id = Guid.Parse("b3c0d309-f657-4c67-b710-01f9a8ac74fa"), Type = TextBlockType.Text, Text = "You gain a +10-foot status bonus to your Speed when you’re not wearing armor." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("b530f898-f91e-4fd3-a1d9-e2d2113b0412"), Feats.Instances.MonkDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("883ed9ca-dd2c-479e-bfea-cdd1e0a74892"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
