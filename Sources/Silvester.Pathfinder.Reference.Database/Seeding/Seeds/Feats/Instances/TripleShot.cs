using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TripleShot : Template
    {
        public static readonly Guid ID = Guid.Parse("aca0ce09-1aa9-4f8e-a2d6-41780048f870");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Triple Shot",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d9b1e562-feb6-47f2-8d4b-1d8ec769ba78"), Type = TextBlockType.Text, Text = "You can quickly fire multiple shots with greater control. When you use (feat: Double Shot), you can make the attacks against the same target. You can add an additional action to (feat: Double Shot) to make three ranged (action: Strikes | Strike) instead of two. If you do, the penalty is -4. All attacks count toward your multiple attack penalty, but the penalty doesn’t increase until after you’ve made all of them." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("e25960be-c691-40d4-8857-28e6303088c6"), Feats.Instances.DoubleShot.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cd2c2efd-f16a-4cb6-a4df-ab511ce23864"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
