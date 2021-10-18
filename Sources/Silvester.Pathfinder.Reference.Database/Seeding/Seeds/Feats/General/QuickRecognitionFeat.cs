using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.General
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
                ActionTypeId = ActionTypes.Instances.NoAction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("32cdf8c4-ea19-43b2-8cf4-8b462fee385d"), Type = Utilities.Text.TextBlockType.Text, Text = "You Recognize Spells swiftly. Once per round, you can Recognize a Spell using a skill in which you’re a master as a free action." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites()
        {
            yield return new ChoicePrerequisite
            {
                Id = Guid.Parse("769a8ff4-92c8-4d6c-952c-1ec417c687a0"),
                Choices =
                {
                    new HaveSpecificSkillProficiencyPrerequisite { Id = Guid.Parse("a58174cf-b9e6-4bad-afcf-4aa4efe0530c"), RequiredSkillId = Skills.Instances.Arcana.ID, RequiredProficiencyId = Proficiencies.Instances.Master.ID },
                    new HaveSpecificSkillProficiencyPrerequisite { Id = Guid.Parse("519af840-b52b-41a8-927a-502d358e41ab"), RequiredSkillId = Skills.Instances.Nature.ID, RequiredProficiencyId = Proficiencies.Instances.Master.ID },
                    new HaveSpecificSkillProficiencyPrerequisite { Id = Guid.Parse("dfd40c16-203f-4f82-9c7c-f340ace54516"), RequiredSkillId = Skills.Instances.Occultism.ID, RequiredProficiencyId = Proficiencies.Instances.Master.ID },
                    new HaveSpecificSkillProficiencyPrerequisite { Id = Guid.Parse("e520e7b4-b817-4ad3-a3d5-d07b579688bc"), RequiredSkillId = Skills.Instances.Religion.ID, RequiredProficiencyId = Proficiencies.Instances.Master.ID },
                }
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.General.ID;
            yield return Traits.Instances.Skill.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e0c6c576-8205-414f-a41f-5fd9e6a16460"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 265
            };
        }
    }
}
