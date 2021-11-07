using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SubtleShank : Template
    {
        public static readonly Guid ID = Guid.Parse("8d30edae-3f5a-47f1-b7f6-aedc1abaa93d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Subtle Shank",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5822af28-b3e2-490e-bcef-376680ec391e"), Type = TextBlockType.Text, Text = "~ Access: Help either the Washboard Dogs or the Diobel Sweepers destroy their rival." };
            yield return new TextBlock { Id = Guid.Parse("45d4a31b-f219-4b0c-b352-419d07376384"), Type = TextBlockType.Text, Text = "You draw a concealed weapon, attack with it, and then hide it away again in one smooth motion. (action: Interact) to draw the weapon, (action: Strike) with that weapon, and then (action: Conceal | Conceal an Object) it with a Stealth check. The target is flat-footed for this attack." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("cf8664f2-339d-44d0-a3d9-068bc53cb8f2"), Feats.Instances.QuickDraw.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4c0856a7-4d88-48c7-b360-165c4da0f5a5"),
                SourceId = Sources.Instances.AgentsOfEdgewatch.ID,
                Page = -1
            };
        }
    }
}
