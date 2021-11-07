using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DelayTrap : Template
    {
        public static readonly Guid ID = Guid.Parse("09e3dab8-5850-4e29-9d28-de2ac7446067");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Delay Trap",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "A trap within your reach is triggered.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("cf1640cf-934f-4f7d-9d80-abcbc9a9ab7f"), Type = TextBlockType.Text, Text = "You can jam the workings of a trap to delay its effects. Attempt a Thievery check to (action: Disable a Device) on the trap; the DC to do so is increased by 5, and the effects are as follows." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("c5874354-96a0-424e-a068-1d71bc9baaa2"), Feats.Instances.ArcheologistDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("a466b544-05c7-425d-9d5e-32de16166329"),
                CriticalSuccess = "You prevent the trap from being triggered, or you delay the activation until the start or end of your next turn (your choice).",
                Success = "You prevent the trap from being triggered, or you delay the activation until the end of your next turn (whichever is worse for you; GM’s choice).",
                Failure = "No effect.",
                CriticalFailure = "You’re flat-footed until the start of your next turn.", 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("03e4cba1-cff1-43e3-9ae4-298caa113651"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
