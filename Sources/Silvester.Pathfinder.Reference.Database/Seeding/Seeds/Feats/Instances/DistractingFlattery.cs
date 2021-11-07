using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DistractingFlattery : Template
    {
        public static readonly Guid ID = Guid.Parse("ca8e4e69-fd91-4896-b623-aec1e1f3e331");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Distracting Flattery",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You observe a target's attitude toward yourself or your allies decrease as a result of an ally's behavior.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3cb5878e-12ff-4eb8-b7cd-c5b834fc7b99"), Type = TextBlockType.Text, Text = "You know how to maintain a good impression and manage your image, even while keeping uncouth company. Make a Deception check against the target’s Will DC. Regardless of your result, the target is temporarily immune to your Distracting Flattery for 10 minutes." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("1ee57c51-8012-4ba2-accd-67491062abaf"), Feats.Instances.DandyDedication.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("f13e0cf5-42cd-4450-a6a0-b51d6de0dae3"), Proficiencies.Instances.Expert.ID, Skills.Instances.Deception.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("e1f44712-fd26-44cb-ad42-bd573470151a"),
                
                Success = "The target’s attitude doesn’t decrease as a result of you or your ally’s social blunder.",
                Failure = "The target’s attitude decreases, as normal.",
                CriticalFailure = "Your attempt makes matters worse, decreasing the target’s attitude toward you by one step, in addition to any changes from the behavior that triggered this reaction.", 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4fd7b0d7-d391-4b55-8766-cad1ea701513"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
