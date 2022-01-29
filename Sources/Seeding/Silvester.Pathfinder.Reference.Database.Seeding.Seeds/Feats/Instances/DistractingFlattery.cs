using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DistractingFlattery : Template
    {
        public static readonly Guid ID = Guid.Parse("97781f8d-4f77-4d6d-a0e2-debf1d7334fc");

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
            yield return new TextBlock { Id = Guid.Parse("27d8b1a9-9b10-4aeb-8d06-b0db523b015c"), Type = TextBlockType.Text, Text = $"You know how to maintain a good impression and manage your image, even while keeping uncouth company. Make a Deception check against the target's Will DC. Regardless of your result, the target is temporarily immune to your Distracting Flattery for 10 minutes." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("649fc79c-2f79-40dc-9daf-06c94f540e00"), Feats.Instances.DandyDedication.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("a982d633-2394-444a-8474-ed32ea7987ee"), Proficiencies.Instances.Expert.ID, Skills.Instances.Deception.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("82ce6146-8f68-4f67-adb2-9afe258aca95"), Traits.Instances.Archetype.ID);
            builder.Add(Guid.Parse("b54047f8-1265-45a9-9be5-57febaa35bb6"), Traits.Instances.Skill.ID);

        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("07a9d89f-feb3-4583-8e11-c4b9cfba59c7"),
                
                Success = "The target's attitude doesn't decrease as a result of you or your ally's social blunder.",
                Failure = "The target's attitude decreases, as normal.",
                CriticalFailure = "Your attempt makes matters worse, decreasing the target's attitude toward you by one step, in addition to any changes from the behavior that triggered this reaction.", 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("89e2e9d5-bde1-4572-8470-46d0f34a3653"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
