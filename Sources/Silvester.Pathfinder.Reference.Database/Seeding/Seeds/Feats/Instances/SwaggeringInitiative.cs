using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SwaggeringInitiative : Template
    {
        public static readonly Guid ID = Guid.Parse("df516e6b-c084-4eb1-acc1-dc024f363cfd");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Swaggering Initiative",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You are about to roll initiative.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("03784946-1120-44fe-8795-f4144651a49f"), Type = TextBlockType.Text, Text = "You swagger readily into any fight – even an ambush. You gain a +2 circumstance bonus to your initiative roll and can (action: Interact) to draw a weapon." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5b30829e-8772-4363-bf95-469f02164b67"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
