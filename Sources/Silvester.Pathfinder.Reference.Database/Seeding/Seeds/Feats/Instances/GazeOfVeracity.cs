using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GazeOfVeracity : Template
    {
        public static readonly Guid ID = Guid.Parse("6d907304-c8e2-41f0-8255-969b30ae6100");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Gaze of Veracity",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9de97110-8abf-486f-8759-b93817796a99"), Type = TextBlockType.Text, Text = "You can channel your mask’s power to pierce through lies and see the truth in any situation. Increase the number of Focus Points in your focus pool by 1. While wearing your mask, you can cast the (spell: glimpse the truth) cleric domain spell as a divine focus spell." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("45d180f5-231d-4c3e-8350-585e21f03ecd"), Feats.Instances.HellknightSigniferDedication.ID);
            builder.HaveFocusPool(Guid.Parse("decb2fbd-6368-4395-9616-c52334d77ec5"));
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1e383e98-ec62-422e-a2f6-3ae4240b7e33"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
