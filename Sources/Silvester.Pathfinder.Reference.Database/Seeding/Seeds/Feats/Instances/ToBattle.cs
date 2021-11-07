using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ToBattle : Template
    {
        public static readonly Guid ID = Guid.Parse("4b17190c-d029-4c9d-842a-30baf99330cb");

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
            yield return new TextBlock { Id = Guid.Parse("9165e556-66cc-4d1d-b9cc-5434c5016379"), Type = TextBlockType.Text, Text = "With a resounding cry, you rally your ally to the offensive. Choose one ally within your marshal’s aura who has a reaction available. If you spend 1 action, that ally can use their reaction to immediately (action: Stride). If you spend 2 actions, that ally can use their reaction to immediately (action: Strike)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("b0dffa21-2dce-4722-80c5-d6946ed2ff17"), Feats.Instances.MarshalDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cd3edd27-480c-4622-a5dc-4a51ad3aa058"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
