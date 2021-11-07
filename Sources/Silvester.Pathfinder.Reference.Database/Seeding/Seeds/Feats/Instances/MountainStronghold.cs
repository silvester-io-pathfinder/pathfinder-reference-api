using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MountainStronghold : Template
    {
        public static readonly Guid ID = Guid.Parse("093afef9-956c-46c8-b7f4-c123869a6819");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Mountain Stronghold",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "If you have this feat, the Dexterity modifier cap to your AC while you're in Mountain Stance increases from +0 to +1.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2ac07b98-e9ab-4661-b634-ef93922a2aac"), Type = TextBlockType.Text, Text = "You focus on your connection to the earth and call upon the mountain to block attacks against you. You gain a +2 circumstance bonus to AC until the beginning of your next turn." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("9a0839a6-0016-4e85-ab06-0adc3854180d"), Feats.Instances.MountainStance.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("abc28449-2568-42b3-a7a4-fa1140ef1c54"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
