using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GodlessHealing : Template
    {
        public static readonly Guid ID = Guid.Parse("413e8429-b9dc-4551-bfab-74b36db9dfe0");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Godless Healing",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ae9fea5a-695f-475f-be66-37c75758f288"), Type = TextBlockType.Text, Text = "You recover an additional 5 Hit Points from a successful attempt to (action: Treat your Wounds | Treat Wounds) or use (feat: Battle Medicine) on you. After you or an ally use (feat: Battle Medicine) on you, you become temporarily immune to that (feat: Battle Medicine) for only 1 hour, instead of 1 day." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("66f9486d-e603-4e59-b36e-84737a13f0aa"), Feats.Instances.BattleMedicine.ID);
            builder.Manual(Guid.Parse("b366e6b0-97bc-40f0-999e-bf4ba502af87"), "Can't have a patron deity.");
            //TODO: Add prerequisites.
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1b190f4c-e76a-4521-ae35-d3d63477ae91"),
                SourceId = Sources.Instances.LostOmensWorldGuide.ID,
                Page = -1
            };
        }
    }
}
