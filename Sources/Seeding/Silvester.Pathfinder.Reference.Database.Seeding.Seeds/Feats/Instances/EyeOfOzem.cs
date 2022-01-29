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
    public class EyeOfOzem : Template
    {
        public static readonly Guid ID = Guid.Parse("13cc8e3a-6ab3-46fc-a1c3-c6b78d8d7e2f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Eye of Ozem",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("fa4bbc33-4c46-4346-87d3-1e915cb045b2"), Type = TextBlockType.Text, Text = $"You've learned how to spot danger at a distance, allowing you to serve as a sentry with ease. You gain a +2 circumstance bonus to initiative rolls when using Perception, and when you're {ToMarkdownLink<Models.Entities.Archetype>("Scouting", Archetypes.Instances.Scout.ID)}, you grant your allies a +2 circumstance bonus instead of +1." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("56bc6604-b655-4927-9304-f979cb5d505e"), Feats.Instances.LastwallSentryDedication.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("8380d4a3-a27a-42b3-82cd-fc4338308665"), Proficiencies.Instances.Expert.ID, Skills.Instances.Perception.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("9981599a-a5de-4571-a8b2-f2317124dd85"), Traits.Instances.Archetype.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c216cd1e-3cbd-4043-972b-37de8f9242c3"),
                SourceId = Sources.Instances.LostOmensWorldGuide.ID,
                Page = -1
            };
        }
    }
}
