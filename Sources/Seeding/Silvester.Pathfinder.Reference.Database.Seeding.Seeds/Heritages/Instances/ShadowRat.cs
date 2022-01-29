using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Heritages.Instances
{
    public class ShadowRat : Template
    {
        public static readonly Guid ID = Guid.Parse("9f98cb51-dc3d-4744-9bb2-08130ba5d345");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Shadow Rat"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("6d4dea7d-79cb-4bab-9ed6-7323847ede12"), Type = TextBlockType.Text, Text = "Your ancestors lived in dark spaces underground, granting you dark fur and a vaguely unnatural mien that unnerves sapient creatures and frightens animals. You gain the trained proficiency rank in Intimidation and can use Intimidation to Coerce animals. When you Demoralize an animal, you don't take a penalty for not sharing a language with it. If you would automatically become trained in Intimidation (from your background or class, for example), you become trained in another skill of your choice." };
            yield return new TextBlock { Id = Guid.Parse("c73e2e20-f12f-471e-b6a8-7cae412f5889"), Type = TextBlockType.Text, Text = "Animals' attitudes toward you begin one degree worse than normal, usually starting at unfriendly instead of indifferent for domesticated animals, and hostile instead of unfriendly for wild animals." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.AddOr(Guid.Parse("b8cb170e-d3d0-4829-8215-5d98348d9a26"), or =>
            {
                or.GainSpecificSkillProficiency(Guid.Parse("b3776993-82e5-4f6f-b8fd-19698e69938e"), Proficiencies.Instances.Trained.ID, Skills.Instances.Intimidation.ID);
                or.GainAnySkillProficiency(Guid.Parse("9bf4c075-0d24-4843-9d20-8173a9ff2753"), Proficiencies.Instances.Trained.ID)
                    .AddPrerequisites(Guid.Parse("1853d04b-da82-4591-8c6a-15e90076d207"), prerequisites =>
                    {
                        prerequisites.HaveSpecificSkillProficiency(Guid.Parse("35ef52d1-f4e4-4545-a9d2-2a8501ebdfb9"), Proficiencies.Instances.Trained.ID, Skills.Instances.Intimidation.ID);
                    });
            });
            builder.Manual(Guid.Parse("791abfa5-006d-4b51-ba03-da3dd1fe79e9"), "You can use Intimidation to Coerce animals.");
            builder.Manual(Guid.Parse("bbe161c0-6e0e-45f5-be75-40d823ff35b8"), "When you Demoralize an animal, you don't take a penalty for not sharing a language with it.");
            builder.Manual(Guid.Parse("d19114c4-2e95-4c6a-be94-c5054ba3f449"), "Animals' attitudes toward you begin one degree worse than normal, usually starting at unfriendly instead of indifferent for domesticated animals, and hostile instead of unfriendly for wild animals.");
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5d532e39-605e-40a2-a2db-f2a6320221f9"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 22
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Ancestries.Instances.Ratfolk.ID;
        }
    }
}
