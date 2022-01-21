using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ShieldedStride : Template
    {
        public static readonly Guid ID = Guid.Parse("cf132ddd-dd07-49c5-b9b9-e157bd6de366");

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
            yield return new TextBlock { Id = Guid.Parse("96680656-e5e5-42ba-ae5e-d6dfbf6b22da"), Type = TextBlockType.Text, Text = "When your shield is up, your enemies' blows can't touch you. When you have your shield raised, you can (action: Stride) to move half your Speed without triggering reactions that are triggered by your movement (such as (feat: Attacks of Opportunity | Attack of Opportunity)). You can use Shielded Stride while (action: Flying | Fly) or (action: Swimming | Swim) instead of (action: Striding | Stride) if you have the corresponding movement type." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("abb01dad-e5cd-4f5b-847c-fde4660c8e87"), Feats.Instances.VikingDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5306c66d-0f91-4412-90ee-4727f609fa5c"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
