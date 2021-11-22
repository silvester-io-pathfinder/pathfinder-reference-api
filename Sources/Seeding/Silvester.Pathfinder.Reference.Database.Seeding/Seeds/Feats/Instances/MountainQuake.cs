using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MountainQuake : Template
    {
        public static readonly Guid ID = Guid.Parse("c2dba461-59b5-4453-99c7-b81d616f47fc");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Mountain Quake",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "If you have this feat, the Dexterity modifier cap to your AC while using Mountain Stance increases from +1 to +2.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2fb42ad5-c4c9-4262-b35b-88e9aeca465c"), Type = TextBlockType.Text, Text = "You stomp, shaking the earth beneath you. Creatures on the ground within a 20-foot emanation take damage equal to your Strength modifier (minimum 0), which they can resist with a basic Fortitude save. On a failure, they also fall prone. After you use this action, you can't use it again for 1d4 rounds." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("91d78a40-6611-40e7-aa14-6481fd64428b"), Feats.Instances.MountainStronghold.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("eab84778-c2d8-470b-9580-8ce60c682455"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
