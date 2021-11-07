using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TriangleShot : Template
    {
        public static readonly Guid ID = Guid.Parse("82c043cf-8f67-4d96-830f-441319e367c2");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Triangle Shot",
                Level = 18,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("dfbf82be-2a79-48f7-b35f-3f59499c2b12"), Type = TextBlockType.Text, Text = "You string three arrows to your bow and fire them all at once. Make three ranged (action: Strikes | Strike) against a single target with the required weapon, each using your current multiple attack penalty, and you take an additional –2 penalty. This counts as two attacks when calculating your multiple attack penalty, and you combine the attacks’ damage for the purpose of resistances and weaknesses. Your (feat: Stunning Fist) benefit applies to Triangle Shot, even though it isn’t a (feat: Flurry of Blows). If all three (action: Strikes | Strike) hit, the target takes 3d6 persistent bleed damage." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("97565204-f7d1-48be-8ea1-7726e363a431"), Feats.Instances.MonasticArcherStance.ID);
            builder.HaveSpecificFeat(Guid.Parse("6d94a186-e142-4616-a7a6-361a44f3ed28"), Feats.Instances.StunningFist.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("de009b7b-3b01-487b-80c2-9f57f49eee5f"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
