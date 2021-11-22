using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BulletDancerStance : Template
    {
        public static readonly Guid ID = Guid.Parse("6af32d04-0827-4a84-a355-286948cc9909");

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
            yield return new TextBlock { Id = Guid.Parse("da992990-02ff-471f-8e80-a9685103d509"), Type = TextBlockType.Text, Text = "You enter a specialized stance for a unique martial art centered around the use of simple firearms. While in this stance, the only (action: Strikes|Strike) you can make are those using bayonets, reinforced stocks, and simple firearms. You can use (feat: Flurry of Blows) with these weapons. You can use your other monk feats or monk abilities that normally require unarmed attacks with bayonets and reinforced stocks, so long as the feat or ability doesn't require a single, specific (action: Strike). You can also use them with simple firearms when attacking within half the first range increment." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e682158a-6870-4afe-85f5-1d12124e707a"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
