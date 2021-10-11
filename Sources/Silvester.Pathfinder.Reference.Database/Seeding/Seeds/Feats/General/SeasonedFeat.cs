using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.General
{
    public class SeasonedFeat : Template
    {
        public static readonly Guid ID = Guid.Parse("e81f8295-4e19-4f8a-b3fd-4bbe3719525c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Seasoned",
                Level = 1,
                FeatTypeId = FeatTypes.Instances.Skill.ID,
                ActionTypeId = ActionTypes.Instances.NoAction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d7b38b3b-24c1-4b46-8f6c-91d033f11e88"), Type = TextBlockType.Text, Text = "You've mastered the preparation of many types of food and drink. You gain a +1 circumstance bonus to checks to Craft food and drink, including potions. If you are a master in one of the prerequisite skills, this bonus increases to +2." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites()
        {
            yield return new OrPrerequisite
            {
                Id = Guid.Parse("82b561b2-92f2-417f-b457-6143c95c4bac"),
                Choices =
                {
                    new LorePrerequisite { Id = Guid.Parse("66575d15-d251-45a8-9f0a-40959a05a627"), RequiredLoreId = Lores.Instances.Alcohol.ID, RequiredProficiencyId = Proficiencies.Instances.Trained.ID },
                    new LorePrerequisite { Id = Guid.Parse("eea54f9c-5d65-4488-8b78-e727e2088b0a"), RequiredLoreId = Lores.Instances.Cooking.ID, RequiredProficiencyId = Proficiencies.Instances.Trained.ID },
                    new SkillPrerequisite { Id = Guid.Parse("d59f0f25-213e-4cdc-b549-c52c6191f28d"), RequiredSkillId = Skills.Instances.Crafting.ID, RequiredProficiencyId = Proficiencies.Instances.Trained.ID }
                }
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.General.ID;
            yield return Traits.Instances.Skill.ID;
        }
    }
}
