using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.General
{
    public class HeftyHaulerFeat : Template
    {
        public static readonly Guid ID = Guid.Parse("18e0c385-d2ba-4646-989d-2e49d43d5f36");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Hefty Hauler",
                Level = 1,
                FeatTypeId = FeatTypes.Instances.General.ID,
                ActionTypeId = ActionTypes.Instances.NoAction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b916a391-2032-4ec4-b914-f40d36019fa8"), Type = Utilities.Text.TextBlockType.Text, Text = "You can carry more than your frame implies. Increase your maximum and encumbered Bulk limits by 2." };
        }

        protected override IEnumerable<Prerequisite> GetPrerequisites()
        {
            yield return new SkillPrerequisite { Id = Guid.Parse("eae50f6e-3de5-4ff9-94e9-f0d0dfe8df88"), RequiredSkillId = Skills.Instances.Athletics.ID, RequiredProficiencyId = Proficiencies.Instances.Trained.ID };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.General.ID;
            yield return Traits.Instances.Skill.ID;
        }
    }
}
