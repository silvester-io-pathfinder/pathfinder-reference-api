using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Feats.General
{
    public class PlanarSurvivalFeat : Template
    {
        public static readonly Guid ID = Guid.Parse("9415b689-43b4-4177-b861-32cab298b5fe");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Planar Survival",
                Level = 7,
                FeatTypeId = FeatTypes.Instances.General.ID,
                ActionTypeId = ActionTypes.Instances.NoAction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3345970c-ae02-486b-a2ea-75eef371f9a4"), Type = Utilities.Text.TextBlockType.Text, Text = "You can Subsist using Survival on different planes, even those without resources or natural phenomena you normally need. For instance, you can forage for food even if the plane lacks food that could normally sustain you. A success on your check to Subsist can also reduce the damage dealt by the plane, at the GM’s discretion." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites()
        {
            yield return new SkillPrerequisite { Id = Guid.Parse("a153e8ba-11f0-417b-ae6d-52be52035560"), RequiredSkillId = Skills.Instances.Survival.ID, RequiredProficiencyId = Proficiencies.Instances.Master.ID };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.General.ID;
            yield return Traits.Instances.Skill.ID;
        }
    }
}
