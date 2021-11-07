using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class KeepPace : Template
    {
        public static readonly Guid ID = Guid.Parse("01bbf982-665b-4bfa-a5d2-5a90f200025f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Keep Pace",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "Your prey is within reach and attempts to move away from you.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1ec8682e-9099-49b2-8048-9b53b5231b7e"), Type = TextBlockType.Text, Text = "Your prey can’t escape. (action: Stride) up to your Speed, following the foe and keeping it in reach throughout its movement until it stops moving or you’ve moved your full Speed. You can use Keep Pace to (action: Burrow), (action: Climb), (action: Fly), or (action: Swim) instead of (action: Stride) if you have the corresponding movement type." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("960fb503-a8ea-45e3-aad2-79998505dc9c"), Feats.Instances.BountyHunterDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("949dd80b-7aa7-4224-a424-caa5484905da"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
