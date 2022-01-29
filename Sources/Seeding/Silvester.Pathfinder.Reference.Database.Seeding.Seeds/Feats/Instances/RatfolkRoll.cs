using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RatfolkRoll : Template
    {
        public static readonly Guid ID = Guid.Parse("c17bf4f5-418d-48e3-8dc8-3c97be04463f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Ratfolk Roll",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("31ea0280-892d-4d91-8f04-ede78159859e"), Type = TextBlockType.Text, Text = $"Your ability to curl up into a tight ball comes in handy. You roll up into a ball and move up to four times your Speed in a straight line down an incline. If you reach the bottom of the incline or hit an obstacle during this first turn of movement, you stop rolling safely. Otherwise, you automatically keep rolling at this Speed during subsequent turns until you hit the bottom of the incline or an obstacle ends this movement (which can happen in the middle of your turn). You're slowed 2 each turn after the first that you keep rolling, and if you hit an obstacle on a turn after the first, you and the obstacle both take 4d6 bludgeoning damage and you stop rolling." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Move.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Ratfolk.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b141b1e2-3f18-41bf-896e-1240700f2787"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
