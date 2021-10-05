using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.General
{
    public class CatFallFeat : Template
    {
        public static readonly Guid ID = Guid.Parse("9c848549-edaa-49b9-aa64-fcea1ccbc966");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Cat Fall",
                Level = 1,
                FeatTypeId = FeatTypes.Instances.General.ID,
                ActionTypeId = ActionTypes.Instances.NoAction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1e6015e9-a70f-4e85-810c-bbe811bd477d"), Type = Utilities.Text.TextBlockType.Text, Text = "Your catlike aerial acrobatics allow you to cushion your falls. Treat falls as 10 feet shorter. If you’re an expert in Acrobatics, treat falls as 25 feet shorter. If you’re a master in Acrobatics, treat them as 50 feet shorter. If you’re legendary in Acrobatics, you always land on your feet and don’t take damage, regardless of the distance of the fall." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites()
        {
            yield return new SkillPrerequisite { Id = Guid.Parse("9e791723-1f8e-480d-844f-0e0fe4aae005"), RequiredSkillId = Skills.Instances.Acrobatics.ID, RequiredProficiencyId = Proficiencies.Instances.Trained.ID };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.General.ID;
            yield return Traits.Instances.Skill.ID;
        }
    }
}
