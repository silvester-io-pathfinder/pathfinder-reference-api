using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SneakAttacker : Template
    {
        public static readonly Guid ID = Guid.Parse("f4f624fe-c41c-492f-9c55-fb210228192b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Sneak Attacker",
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
            yield return new TextBlock { Id = Guid.Parse("65f7d3fa-2dd1-4bee-b75f-20641f3cbcd4"), Type = TextBlockType.Text, Text = "You gain the sneak attack class feature (page 181), except you deal 1d6 precision damage regardless of your level. Sneak attack from multiple sources isn’t cumulative. If you have sneak attack from more than one source, use only the highest number of dice when you sneak attack rather than adding the amounts together." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("33532452-1bae-42f4-9b6f-4f181a6ec096"), Feats.Instances.AssasinDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a1470a44-2ae5-4b76-975c-ad2d2a496c11"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
