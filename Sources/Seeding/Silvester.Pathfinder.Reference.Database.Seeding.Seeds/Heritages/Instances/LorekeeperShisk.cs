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
        public static readonly Guid ID = Guid.Parse("fd2cb255-1278-4801-8730-e57befb7438b");

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
            yield return new TextBlock { Id = Guid.Parse("a02f18b8-61e1-48b8-9e21-5d6aa453d430"), Type = TextBlockType.Text, Text = "You grew up surrounded by knowledge and secrets. You become trained in one Lore skill and one other Intelligence- or Wisdom-based skill of your choice. At 5th level, you become expert in the chosen skills." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyLoreProficiency(Guid.Parse("1dea6b4f-faf4-41a3-a06d-f9f92ed5e023"), Proficiencies.Instances.Trained.ID);
            builder.AddOr(Guid.Parse("d2c5189e-86a8-43d8-bffa-073fb4c0e7f1"), or =>
            {
                or.ChooseSpecificStatAnySkill(Guid.Parse("a3d7fcd9-3f12-4f99-ad66-3f46a2c4fd38"), Guid.Parse("ec6da038-1253-43d2-8df7-e3d7c08fb80b"), Stats.Instances.Intelligence.ID, choice =>
                {
                    choice.GainChosenSkillProficiency(Guid.Parse("7ea203a9-d17f-46aa-99b4-77bb13d3f08f"), Proficiencies.Instances.Trained.ID);
                    choice.GainChosenSkillProficiency(Guid.Parse("43c81921-ac1b-4086-ad1a-ed023bd3f027"), Proficiencies.Instances.Expert.ID)
                        .AddPrerequisites(Guid.Parse("ebfeefca-6610-4baa-b2ab-1ae5cd303723"), prerequisites =>
                        {
                            prerequisites.HaveSpecificLevel(Guid.Parse("16c6b73e-62b9-42a1-ab1b-c6ac64ce88d4"), Comparator.GreaterThanOrEqualTo, requiredLevel: 5);
                        });
                });

                or.ChooseSpecificStatAnySkill(Guid.Parse("4a5d9284-c6e0-447c-9819-9117eda29a83"), Guid.Parse("fac27632-373d-443d-a6f7-51d48cd09eca"), Stats.Instances.Wisdom.ID, choice =>
                {
                    choice.GainChosenSkillProficiency(Guid.Parse("7543ef5b-cd1a-4117-85c3-9e5a784e22a5"), Proficiencies.Instances.Trained.ID);
                    choice.GainChosenSkillProficiency(Guid.Parse("3df47f14-f668-48d1-a876-d5f2987af673"), Proficiencies.Instances.Expert.ID)
                        .AddPrerequisites(Guid.Parse("70ff715e-0782-4a30-8a85-acef2bf76249"), prerequisites =>
                        {
                            prerequisites.HaveSpecificLevel(Guid.Parse("a8b61af0-4e52-46bb-91ca-680cd7d52b37"), Comparator.GreaterThanOrEqualTo, requiredLevel: 5);
                        });
                });
            });
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4e149fff-329e-4f8e-8b04-27eb1dcc3990"),
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
