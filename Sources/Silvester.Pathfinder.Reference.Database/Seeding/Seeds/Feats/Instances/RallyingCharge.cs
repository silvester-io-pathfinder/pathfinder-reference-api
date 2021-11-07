using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RallyingCharge : Template
    {
        public static readonly Guid ID = Guid.Parse("6c8c4ffe-7bbf-4eb6-aa24-9f0f0904a371");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Rallying Charge",
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
            yield return new TextBlock { Id = Guid.Parse("dd1aed40-5be2-4cbf-8f0a-1bad457f9385"), Type = TextBlockType.Text, Text = "Your fearless charge into battle reinvigorates your allies to carry on the fight. You (action: Stride) up to your Speed and make a melee (action: Strike). If your (action: Strike) hits and damages an enemy, each ally within 60 feet who saw you hit gains temporary Hit Points equal to your Charisma modifier. These temporary Hit Points last until the start of your next turn." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("4438c097-9f87-4673-969a-f9fea70ccb18"), Feats.Instances.MarshalDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2587545e-bb1c-4565-91fd-f323f8cb8ee3"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
