using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Feats.General
{
    public class LastingCoercionFeat : Template
    {
        public static readonly Guid ID = Guid.Parse("37f7d759-3c83-491a-a516-b41b64cf57a7");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Lasting Coercion",
                Level = 2,
                FeatTypeId = FeatTypes.Instances.General.ID,
                ActionTypeId = ActionTypes.Instances.NoAction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f1ce54f4-d426-4acf-bda9-645a50a04a01"), Type = Utilities.Text.TextBlockType.Text, Text = "When you successfully Coerce someone, the maximum time they comply increases to a week, still determined by the GM. If you’re legendary, the maximum increases to a month." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites()
        {
            yield return new SkillPrerequisite { Id = Guid.Parse("4e970e30-b49a-4f75-922f-fc222288a0e6"), RequiredSkillId = Skills.Instances.Intimidation.ID, RequiredProficiencyId = Proficiencies.Instances.Expert.ID };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.General.ID;
            yield return Traits.Instances.Skill.ID;
        }
    }
}
