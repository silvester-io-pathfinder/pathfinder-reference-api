using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.PlayModes.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Backgrounds.Instances
{
    public class Teacher : Template
    {
        public static readonly Guid ID = Guid.Parse("dce9e47d-034c-49ef-88f8-fb05059491f7");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Teacher",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("cf67a157-8336-44d8-aa3a-00ef528851e9"), Type = TextBlockType.Text, Text = "You are incredibly knowledgeable, skilled, and perhaps even trained to teach children and adults about the world and its wonders. From books to classes, you're committed to imparting knowledge to all. Not everything can be taught or learned from a book, though, so you've become an adventurer to learn subjects more directly and bring that wisdom back to your students." };
        }

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new GainSpecificAbilityBoostEffect
            {
                Id = Guid.Parse("e69a5ee2-2e59-4a3d-bd6b-cdcd7f9e7cdf"),
                RequiredStats = new StatEffectBinding[]
                {
                    new StatEffectBinding{Id = Guid.Parse("6d37382d-a27d-4f14-b00f-c280376c6f6a"), StatId = Stats.Instances.Intelligence.ID },
                    new StatEffectBinding{Id = Guid.Parse("e523e97f-21cb-457f-8738-a8b7ab767577"), StatId = Stats.Instances.Wisdom.ID }
                }
            };

            yield return new GainAnyAbilityBoostEffect
            {
                Id = Guid.Parse("d48ad6ae-2f31-4724-8521-863ab8dcb550")
            };

            yield return new ChoiceEffect
            {
                Id = Guid.Parse("3bd4cef7-6ef1-4d21-9322-6191078185ac"),
                Choices = new Effect[]
                {
                    new GainSpecificSkillProficiencyEffect { Id = Guid.Parse("bce7b4dd-5cb4-49cb-b133-15fd7ab87c2d"), ProficiencyId = Proficiencies.Instances.Trained.ID, SkillId = Skills.Instances.Performance.ID },
                    new GainSpecificSkillProficiencyEffect { Id = Guid.Parse("e1b962ae-0e08-4876-bc30-e7138ae7620f"), ProficiencyId = Proficiencies.Instances.Trained.ID, SkillId = Skills.Instances.Society.ID },
                }
            };

            yield return new GainSpecificLoreProficiencyEffect
            {
                Id = Guid.Parse("dca0d141-fe14-4746-be40-0f9dc37c95c5"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                LoreId = Lores.Instances.Academia.ID
            };

            yield return new GainSpecificFeatEffect
            {
                Id = Guid.Parse("9770f525-7806-4bc5-9fb2-246c361a0f64"),
                FeatId = Feats.General.ExperiencedProfessionalFeat.ID
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0ff21725-0e45-42cf-affb-aac5977c2c0e"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 49
            };
        }
    }
}
