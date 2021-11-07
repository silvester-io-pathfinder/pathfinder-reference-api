using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FlyingBlade : Template
    {
        public static readonly Guid ID = Guid.Parse("0ec36d11-a1a6-4414-becd-2380ec96d7e3");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Flying Blade",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7d2600e8-0f93-44bc-afe4-554ac3ff07e5"), Type = TextBlockType.Text, Text = "You’ve learned to apply your flashy techniques to thrown weapons as easily as melee attacks. When you have panache, you apply your precise strike damage on ranged (action: Strikes | Strike) you make with a thrown weapon within that weapon’s first range increment. The (trait: thrown) weapon must be an (trait: agile) or (trait: finesse) weapon. This also allows you to make a thrown weapon ranged (action: Strike) for (feat: Confident Finisher) and any other (trait: finisher) that includes a (action: Strike) that can benefit from your precise strike." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificClassFeature(Guid.Parse("0e7da739-693d-4adf-8a60-445da10b9914"), ClassFeatures.Swashbucklers.PreciseStrike.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9ad90c1b-8da3-44ac-8fb1-98b99701b560"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
