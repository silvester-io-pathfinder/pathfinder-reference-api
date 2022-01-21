using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DelayTrap : Template
    {
        public static readonly Guid ID = Guid.Parse("d84d7671-66fa-43d8-98ba-f9bad1f42a70");

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
            yield return new TextBlock { Id = Guid.Parse("dbabd162-392a-4b95-930c-8a501da22d13"), Type = TextBlockType.Text, Text = $"You can jam the workings of a trap to delay its effects. Attempt a Thievery check to {ToMarkdownLink<Models.Entities.SkillAction>("Disable a Device", SkillActions.Instances.DisableADevice.ID)} on the trap; the DC to do so is increased by 5, and the effects are as follows." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("0cf14294-fedc-4f57-9537-9fe8efc5bba2"), Feats.Instances.ArchaeologistDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("6f054247-d487-42e0-b7c6-cc0dfe3571ac"),
                CriticalSuccess = "You prevent the trap from being triggered, or you delay the activation until the start or end of your next turn (your choice).",
                Success = "You prevent the trap from being triggered, or you delay the activation until the end of your next turn (whichever is worse for you; GM's choice).",
                Failure = "No effect.",
                CriticalFailure = "You're flat-footed until the start of your next turn.", 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ecaa6259-cee5-45be-910f-5cedfb176a56"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
