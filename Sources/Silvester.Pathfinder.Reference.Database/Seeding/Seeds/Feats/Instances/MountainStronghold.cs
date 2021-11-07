using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MountainStronghold : Template
    {
        public static readonly Guid ID = Guid.Parse("dd441dc0-867e-43dc-86e2-e64984250424");

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
            yield return new TextBlock { Id = Guid.Parse("0baf5fef-4f44-4d92-8fb3-2a9b5300f815"), Type = TextBlockType.Text, Text = "You focus on your connection to the earth and call upon the mountain to block attacks against you. You gain a +2 circumstance bonus to AC until the beginning of your next turn." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("805bec6b-05e6-4e60-80f5-e9977f6035a6"), Feats.Instances.MountainStance.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a4706211-0f77-41a8-90f8-a1c7fae7fd9a"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
