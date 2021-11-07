using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ShieldedStride : Template
    {
        public static readonly Guid ID = Guid.Parse("142f6ce0-c5db-4950-93ab-2cf1e90db7bc");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Shielded Stride",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("93e0602e-589c-4f13-b244-e060a233485e"), Type = TextBlockType.Text, Text = "When your shield is up, your enemies’ blows can’t touch you. When you have your shield raised, you can (action: Stride) to move half your Speed without triggering reactions that are triggered by your movement (such as (feat: Attacks of Opportunity | Attack of Opportunity)). You can use Shielded Stride while (action: Flying | Fly) or (action: Swimming | Swim) instead of (action: Striding | Stride) if you have the corresponding movement type." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("9ca99212-d2c8-4347-a070-a34acb8646a8"), Feats.Instances.VikingDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("432ce9c5-16a2-42a3-b679-ac5a1c486a46"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
