using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SeekerArrow : Template
    {
        public static readonly Guid ID = Guid.Parse("bcc1643c-d4a6-409c-a1f3-558b3be89588");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Seeker Arrow",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("cb65ae60-fa35-4dde-8c63-e79108cd5d24"), Type = TextBlockType.Text, Text = "Your shots zip around corners and fly at impossible angles to reach your target. Make a bow (action: Strike) against a foe you can see; the ammunition travels to your target, even around corners. You ignore the target's concealed condition and all cover." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("f0a00960-265d-4ecc-8304-782f85ccc29d"), Feats.Instances.EldritchArcherDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1fb00d79-a4fe-4b85-b5ca-28387f1fd819"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
