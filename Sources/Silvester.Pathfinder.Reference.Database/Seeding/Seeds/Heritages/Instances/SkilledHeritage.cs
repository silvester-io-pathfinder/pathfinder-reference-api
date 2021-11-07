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
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Your ingenuity allows you to train in a wide variety of skills. You become trained in one skill of your choice. At 5th level, you become an expert in the chosen skill." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.ChooseAnySkill(Guid.Parse(""), Guid.Parse(""), choice => 
            {
                choice.GainChosenSkillProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID);
                choice.GainChosenSkillProficiency(Guid.Parse(""), Proficiencies.Instances.Expert.ID)
                    .AddPrerequisites(Guid.Parse(""), prerequisites => 
                    {
                        prerequisites.HaveSpecificLevel(Guid.Parse(""), Comparator.GreaterThanOrEqualTo, requiredLevel: 5);
                    });
            });
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
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
