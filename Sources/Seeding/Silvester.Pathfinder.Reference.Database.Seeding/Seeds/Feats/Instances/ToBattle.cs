using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ToBattle : Template
    {
        public static readonly Guid ID = Guid.Parse("28f0961e-406f-49e0-af2b-ccb0c2263500");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "To Battle!",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9f9145be-7d92-455e-a793-34c1a6479237"), Type = TextBlockType.Text, Text = "With a resounding cry, you rally your ally to the offensive. Choose one ally within your marshal's aura who has a reaction available. If you spend 1 action, that ally can use their reaction to immediately (action: Stride). If you spend 2 actions, that ally can use their reaction to immediately (action: Strike)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("aeb29afa-0f9f-45c7-8e9f-f5b38db04837"), Feats.Instances.MarshalDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("168f76f9-12dc-4c94-9ded-70823e10d1e0"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
