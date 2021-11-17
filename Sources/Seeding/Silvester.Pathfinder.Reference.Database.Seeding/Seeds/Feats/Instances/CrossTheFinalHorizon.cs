using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CrossTheFinalHorizon : Template
    {
        public static readonly Guid ID = Guid.Parse("18a752ae-764b-44cc-b566-2008477189d3");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Cross the Final Horizon",
                Level = 20,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3e8b8003-b374-4278-9e73-4d641e10d5ed"), Type = TextBlockType.Text, Text = "You (action: Stride) up to your Speed and your ki enshrouds your limbs in a terrifying stormy energy, increasing the reach of your (feat: Sky and Heaven Stance) unarmed attacks by 5 feet." };
            yield return new TextBlock { Id = Guid.Parse("ecca5411-4cce-4818-9045-52a9ed821b5a"), Type = TextBlockType.Text, Text = "At the end of your movement, make up to three (action: Strikes | Strike) against a target you can reach, each at a -2 penalty. Each attack counts toward your multiple attack penalty, but the multiple attack penalty doesn&#39;t increase until after you have made all your attacks. Instead of the usual slashing or piercing damage, the damage for these (action: Strikes | Strike) is either electricity or sonic, as you choose with each (action: Strike). If you successfully hit with all three (action: Strikes | Strike), the target is drained 3." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("2f4ac502-8de0-4c20-987a-33e1e4b25192"), Feats.Instances.SkyAndHeavenStance.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f19cee9b-73e5-4a04-86b6-cd6b4ab50c5a"),
                SourceId = Sources.Instances.AgentsOfEdgewatch.ID,
                Page = -1
            };
        }
    }
}
