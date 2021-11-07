using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Models.Choices.Instances;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Heritages.Instances
{
    public class LorekeeperShisk : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Lorekeeper Shisk"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You grew up surrounded by knowledge and secrets. You become trained in one Lore skill and one other Intelligence- or Wisdom-based skill of your choice. At 5th level, you become expert in the chosen skills." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyLoreProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID);
            builder.AddOr(Guid.Parse(""), or =>
            {
                or.ChooseSpecificStatAnySkill(Guid.Parse(""), Guid.Parse(""), Stats.Instances.Intelligence.ID, choice =>
                {
                    choice.GainChosenSkillProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID);
                    choice.GainChosenSkillProficiency(Guid.Parse(""), Proficiencies.Instances.Expert.ID)
                        .AddPrerequisites(Guid.Parse(""), prerequisites =>
                        {
                            prerequisites.HaveSpecificLevel(Guid.Parse(""), Comparator.GreaterThanOrEqualTo, requiredLevel: 5);
                        });
                });

                or.ChooseSpecificStatAnySkill(Guid.Parse(""), Guid.Parse(""), Stats.Instances.Wisdom.ID, choice =>
                {
                    choice.GainChosenSkillProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID);
                    choice.GainChosenSkillProficiency(Guid.Parse(""), Proficiencies.Instances.Expert.ID)
                        .AddPrerequisites(Guid.Parse(""), prerequisites =>
                        {
                            prerequisites.HaveSpecificLevel(Guid.Parse(""), Comparator.GreaterThanOrEqualTo, requiredLevel: 5);
                        });
                });
            });
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = 123
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Ancestries.Instances.Shisk.ID;
        }
    }
}
