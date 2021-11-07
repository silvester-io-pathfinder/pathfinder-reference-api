using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CrossTheFinalHorizon : Template
    {
        public static readonly Guid ID = Guid.Parse("44c3939c-fb06-4c7f-b691-c261b90ab37f");

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
            yield return new TextBlock { Id = Guid.Parse("43f3d2fe-b369-4945-bfc6-e262aeca291b"), Type = TextBlockType.Text, Text = "You (action: Stride) up to your Speed and your ki enshrouds your limbs in a terrifying stormy energy, increasing the reach of your (feat: Sky and Heaven Stance) unarmed attacks by 5 feet." };
            yield return new TextBlock { Id = Guid.Parse("eef52d55-2185-4e69-9b5a-965f8e2127b9"), Type = TextBlockType.Text, Text = "At the end of your movement, make up to three (action: Strikes | Strike) against a target you can reach, each at a -2 penalty. Each attack counts toward your multiple attack penalty, but the multiple attack penalty doesn&#39;t increase until after you have made all your attacks. Instead of the usual slashing or piercing damage, the damage for these (action: Strikes | Strike) is either electricity or sonic, as you choose with each (action: Strike). If you successfully hit with all three (action: Strikes | Strike), the target is drained 3." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("f72fa4b4-8216-481a-98b8-18d2fd778892"), Feats.Instances.SkyAndHeavenStance.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("77c7bd92-69da-4a46-9bad-6ccb9331868a"),
                SourceId = Sources.Instances.AgentsOfEdgewatch.ID,
                Page = -1
            };
        }
    }
}
