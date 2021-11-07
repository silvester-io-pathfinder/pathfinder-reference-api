using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RicochetShot : Template
    {
        public static readonly Guid ID = Guid.Parse("c4b897dd-b6df-4da6-94cc-7308e8d0cb9b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Ricochet Shot",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c91b0376-9dae-47b0-8ad5-fa2153b3203f"), Type = TextBlockType.Text, Text = "You bounce your shot off a nearby surface to strike your opponent from an unexpected angle. When determining whether a target has cover from your ranged attack with a firearm or crossbow, you can choose one solid surface within your weapon’s first range increment to ricochet your shot off of. If you do, you determine the target’s cover from the point where you ricochet your shot instead of from you." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("88366ead-2f95-48ac-a330-aee03247c27c"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
