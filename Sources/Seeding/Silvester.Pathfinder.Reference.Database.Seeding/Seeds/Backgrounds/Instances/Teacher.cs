using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects;


using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.PlayModes.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

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

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.AddOr(Guid.Parse("9a1d7268-4b60-45fa-b8ba-b1df93ace007"), or =>
            {
                or.GainSpecificAbilityBoost(Guid.Parse("f2650cb0-fe37-4da0-9ddc-4b6f0683acfd"), Stats.Instances.Intelligence.ID);
                or.GainSpecificAbilityBoost(Guid.Parse("ee28c100-5fbb-439d-8e15-47b232b6a892"), Stats.Instances.Wisdom.ID);
            });

            builder.GainAnyAbilityBoost(Guid.Parse("14dd7419-9731-4be7-b70f-1393630df4d1"));

            builder.AddOr(Guid.Parse("43c6d3d3-641a-4fd2-87ef-39a8273be44c"), or =>
            {
                or.GainSpecificSkillProficiency(Guid.Parse("4238390b-f65f-47bc-b8ac-2236e526afc1"), Proficiencies.Instances.Trained.ID, Skills.Instances.Performance.ID);
                or.GainSpecificSkillProficiency(Guid.Parse("e086c069-6284-4eb1-8a67-5c1fb80d3105"), Proficiencies.Instances.Trained.ID, Skills.Instances.Society.ID);
            });
            
            builder.GainSpecificLoreProficiency(Guid.Parse("0ba73fc8-68f0-47ab-8916-d0a8fa64d850"), Proficiencies.Instances.Trained.ID, Lores.Instances.Academia.ID);
            builder.GainSpecificFeat(Guid.Parse("61c7f474-71cb-4a05-8858-c37e22b0f83c"), Feats.Instances.ExperiencedProfessional.ID);
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
