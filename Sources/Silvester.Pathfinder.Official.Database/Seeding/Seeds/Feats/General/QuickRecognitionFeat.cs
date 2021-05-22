using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Feats.General
{
    public class QuickRecognitionFeat : Template
    {
        public static readonly Guid ID = Guid.Parse("8df39189-1886-4523-95b0-5980cad573f4");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Quick Recognition",
                Level = 7,
                FeatTypeId = FeatTypes.Instances.General.ID,
                ActionTypeId = ActionTypes.Instances.NoAction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("32cdf8c4-ea19-43b2-8cf4-8b462fee385d"), Type = Utilities.Text.TextBlockType.Text, Text = "You Recognize Spells swiftly. Once per round, you can Recognize a Spell using a skill in which you’re a master as a free action." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites()
        {
            yield return new OrPrerequisite
            {
                Id = Guid.Parse("769a8ff4-92c8-4d6c-952c-1ec417c687a0"),
                Choices =
                {
                    new SkillPrerequisite { Id = Guid.Parse("a58174cf-b9e6-4bad-afcf-4aa4efe0530c"), RequiredSkillId = Skills.Instances.Arcana.ID, RequiredProficiencyId = Proficiencies.Instances.Master.ID },
                    new SkillPrerequisite { Id = Guid.Parse("519af840-b52b-41a8-927a-502d358e41ab"), RequiredSkillId = Skills.Instances.Nature.ID, RequiredProficiencyId = Proficiencies.Instances.Master.ID },
                    new SkillPrerequisite { Id = Guid.Parse("dfd40c16-203f-4f82-9c7c-f340ace54516"), RequiredSkillId = Skills.Instances.Occultism.ID, RequiredProficiencyId = Proficiencies.Instances.Master.ID },
                    new SkillPrerequisite { Id = Guid.Parse("e520e7b4-b817-4ad3-a3d5-d07b579688bc"), RequiredSkillId = Skills.Instances.Religion.ID, RequiredProficiencyId = Proficiencies.Instances.Master.ID },
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
