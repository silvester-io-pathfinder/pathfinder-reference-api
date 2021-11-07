using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Skyseeker : Template
    {
        public static readonly Guid ID = Guid.Parse("b6a8e3c0-106f-414b-aae5-52f028a2a29f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Skyseeker",
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
            yield return new TextBlock { Id = Guid.Parse("988a5eb8-08ff-470e-ad13-77b76447e856"), Type = TextBlockType.Text, Text = "You (action: Leap) toward an opponent. At any point in the (action: Leap), you can make a single (action: Strike) against a creature within your reach." };
            yield return new TextBlock { Id = Guid.Parse("c540d324-1c02-44b9-b0a0-ce2c7b2b80cb"), Type = TextBlockType.Text, Text = "At 12th level, if you hit with this (action: Strike), instead of finishing your (action: Leap), you can immediately attempt a second (action: Leap) from the space where you struck the target of your (action: Strike). You can make a single (action: Strike) against a target within your reach during this second (action: Leap) as well." };
            yield return new TextBlock { Id = Guid.Parse("e5a2602f-a8e0-449b-ae58-4942072617c3"), Type = TextBlockType.Text, Text = "At 16th level, you can attempt a third (action: Leap) if your second (action: Strike) hits, and you can attack a target at any point during this third (action: Leap)." };
            yield return new TextBlock { Id = Guid.Parse("2e7c75ee-e981-4eb5-87eb-53b8355c5ad1"), Type = TextBlockType.Text, Text = "All (action: Leaps | Leap) made during this activity gain a +10-foot status bonus to the total height or distance of your leap, and no two (action: Strikes | Strike) can target the same creature." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("5cb6add6-849f-49b0-9e34-5b5a37c76327"), Feats.Instances.SkyAndHeavenStance.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6bba0b52-fd5f-4f7b-b7ff-51baf8fd075c"),
                SourceId = Sources.Instances.AgentsOfEdgewatch.ID,
                Page = -1
            };
        }
    }
}
