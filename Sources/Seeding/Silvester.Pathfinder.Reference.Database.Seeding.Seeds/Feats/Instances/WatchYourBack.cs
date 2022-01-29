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
    public class WatchYourBack : Template
    {
        public static readonly Guid ID = Guid.Parse("319b0c54-d1ac-4e8e-afda-5db305840f69");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Watch Your Back",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("fb85c839-8f19-4f42-9042-424efca940c1"), Type = TextBlockType.Text, Text = $"You menace the target, stoking their fears and drawing their attention. Attempt an Intimidation check against the Will DC of a target within 30 feet. If you succeed, for 1 minute, that target gains a +2 status bonus to Perception checks against you, but they take a –2 status penalty to Will saves against fear effects." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("ab73c6d2-22e2-4bc0-93b2-52d4084874a7"), Proficiencies.Instances.Trained.ID, Skills.Instances.Intimidation.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("a42c15c4-9c80-45cf-a5e0-a915cdae14d1"), Traits.Instances.Emotion.ID);
            builder.Add(Guid.Parse("be848f23-ea12-4b85-b7fa-7e1c5e4a5d44"), Traits.Instances.Fear.ID);
            builder.Add(Guid.Parse("dd61550e-52d5-4be6-a723-6a0cac796585"), Traits.Instances.Mental.ID);
            builder.Add(Guid.Parse("4da3e8c1-5fac-443b-bdbd-3f569a56a31f"), Traits.Instances.Rogue.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("55ad066c-8c71-4f40-b48f-3f997bf9b24d"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
