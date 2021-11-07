using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DoubleShot : Template
    {
        public static readonly Guid ID = Guid.Parse("eb84bbfc-b761-49f2-91f9-b701b8bbb981");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Double Shot",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f5f88432-111d-45e8-9665-8b09de848357"), Type = TextBlockType.Text, Text = "You shoot twice in blindingly fast succession. Make two (action: Strikes | Strike), each against a separate target and with a -2 penalty. Both attacks count toward your multiple attack penalty, but the penalty doesn’t increase until after you’ve made both of them." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("3fb66382-e8f9-40d1-a697-ca8fd482e69c"), Feats.Instances.ArcherDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7db6f77c-b4de-45fa-9e1d-4c0a6abc5225"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
