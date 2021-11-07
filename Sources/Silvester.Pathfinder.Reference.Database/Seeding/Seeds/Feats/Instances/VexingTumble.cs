using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class VexingTumble : Template
    {
        public static readonly Guid ID = Guid.Parse("dd9776ba-5973-455c-b46f-f8fd08161b75");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Vexing Tumble",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("056a88ec-7a16-43b9-9f18-7c91413638d4"), Type = TextBlockType.Text, Text = "You tumble around your foes, expertly avoiding their reactions. (action: Stride) up to half your Speed and roll an Acrobatics check. Compare the result to the Reflex DC of each foe whose reach you began in or enter during the movement, in sequence." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("1af6a9b8-4910-4e25-bb9a-0e35a4aabd63"),
                CriticalSuccess = "This movement doesn’t trigger reactions from the foe, the foe is flat-footed to you until the end of your turn, and you gain panache.",
                Success = "This movement doesn’t trigger reactions from the foe, and you gain panache.",
                
                CriticalFailure = "Your movement immediately stops when you enter the creature’s reach; if you began in the creature’s reach, you don’t move.", 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6db49793-6cd7-46b7-bf63-8f2eae5540f1"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
