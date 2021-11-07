using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BulletDancerStance : Template
    {
        public static readonly Guid ID = Guid.Parse("141eef05-4ae1-4d74-a498-b15fa4d3ba56");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Bullet Dancer Stance",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can't select another dedication feat until you've gained two other feats from the bullet dancer dedication archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("83748878-1167-4040-a449-ea0b29dc59a1"), Type = TextBlockType.Text, Text = "You enter a specialized stance for a unique martial art centered around the use of simple firearms. While in this stance, the only (action: Strikes|Strike) you can make are those using bayonets, reinforced stocks, and simple firearms. You can use (feat: Flurry of Blows) with these weapons. You can use your other monk feats or monk abilities that normally require unarmed attacks with bayonets and reinforced stocks, so long as the feat or ability doesn’t require a single, specific (action: Strike). You can also use them with simple firearms when attacking within half the first range increment." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f15d5f9c-dd2c-4cf7-844c-78505b523782"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
