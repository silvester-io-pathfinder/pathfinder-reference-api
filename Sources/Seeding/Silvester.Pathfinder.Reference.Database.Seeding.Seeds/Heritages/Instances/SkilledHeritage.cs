using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Ancestries.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Choices.Instances;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Heritages.Instances
{
    public class SkilledHeritage : Template
    {
        public static readonly Guid ID = Guid.Parse("fdf36b32-00b2-457f-9aca-aa9378c0f92e");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Skilled Heritage"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("285e7c51-38ed-475e-995e-b7a52b51d274"), Type = TextBlockType.Text, Text = "Your ingenuity allows you to train in a wide variety of skills. You become trained in one skill of your choice. At 5th level, you become an expert in the chosen skill." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.ChooseAnySkill(Guid.Parse("0718bb4f-16ea-4cde-951c-6888ee242fb4"), Guid.Parse("44f9fc09-167a-4300-8c6b-a51983526290"), choice => 
            {
                choice.GainChosenSkillProficiency(Guid.Parse("29a45c57-eff4-42a2-beb9-10a7fb96e025"), Proficiencies.Instances.Trained.ID);
                choice.GainChosenSkillProficiency(Guid.Parse("d455ee98-d628-4cbb-9427-9f4dbf234ac0"), Proficiencies.Instances.Expert.ID)
                    .AddPrerequisites(Guid.Parse("e687e731-dcc8-42dc-8554-8b60a7610682"), prerequisites => 
                    {
                        prerequisites.HaveSpecificLevel(Guid.Parse("1dcd5a5d-ca69-441b-8dd7-52dc37508275"), Comparator.GreaterThanOrEqualTo, requiredLevel: 5);
                    });
            });
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ad3be90a-b9b3-46ba-b0a2-2657133a7416"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 56
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Human.ID;
        }
    }
}
