using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Feats.General
{
    public class PowerfulLeapFeat : Template
    {
        public static readonly Guid ID = Guid.Parse("24bfd707-04bb-4464-a3ad-e1dd040c0377");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Powerful Leap",
                Level = 2,
                FeatTypeId = FeatTypes.Instances.General.ID,
                ActionTypeId = ActionTypes.Instances.NoAction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c30bef55-a24b-4a39-99ef-0e0bd895355a"), Type = Utilities.Text.TextBlockType.Text, Text = "When you Leap, you can jump 5 feet up with a vertical Leap, and you increase the distance you can jump horizontally by 5 feet." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites()
        {
            yield return new SkillPrerequisite { Id = Guid.Parse("080c34b7-ec47-4f28-a240-e4beb705265f"), RequiredSkillId = Skills.Instances.Athletics.ID, RequiredProficiencyId = Proficiencies.Instances.Expert.ID };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.General.ID;
            yield return Traits.Instances.Skill.ID;
        }
    }
}
