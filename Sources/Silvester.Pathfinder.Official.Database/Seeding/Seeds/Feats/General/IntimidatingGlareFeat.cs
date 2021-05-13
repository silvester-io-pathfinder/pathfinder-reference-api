using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Feats.General
{
    public class IntimidatingGlareFeat : Template
    {
        public static readonly Guid ID = Guid.Parse("a1804dfb-e3e0-45aa-b735-2f37fed15779");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Intimidating Glare",
                Level = 1,
                FeatTypeId = FeatTypes.Instances.General.ID,
                ActionTypeId = ActionTypes.Instances.NoAction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("eedd663a-d431-476d-9125-5d45f19d4ec3"), Type = Utilities.Text.TextBlockType.Text, Text = "You can Demoralize with a mere glare. When you do, Demoralize loses the auditory trait and gains the visual trait, and you don’t take a penalty if the creature doesn’t understand your language." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites()
        {
            yield return new SkillPrerequisite { Id = Guid.Parse("a4c66b29-0433-4ac7-901a-0eca0b5e793c"), RequiredSkillId = Skills.Instances.Intimidation.ID, RequiredProficiencyId = Proficiencies.Instances.Trained.ID};
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.General.ID;
            yield return Traits.Instances.Skill.ID;
        }
    }
}
