using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EfficientRituals : Template
    {
        public static readonly Guid ID = Guid.Parse("6e5ace43-188f-403c-abe1-b5f80433efca");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Efficient Rituals",
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
            yield return new TextBlock { Id = Guid.Parse("cf800b9a-4345-4c27-bbda-d4e62f9296e6"), Type = TextBlockType.Text, Text = $"You can perform some rituals in less time. If the ritual normally requires 1 day to cast, you can cast it in 4 hours. If it takes longer than 1 day, you cast it in half the number of days, rounded up." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("36fa1e1d-0818-4fba-a025-aa656e3f7be4"), Feats.Instances.RitualistDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("096179c1-911d-442d-be39-ae7b87c97012"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
